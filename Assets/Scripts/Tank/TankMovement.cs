using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float tankAcceleration = 5.0f;
    public float maxSpeed = 20.0f;
    public float rotateSpeed = 8.0f;
    public float groundedDistance = 0.2f;
    public float turretRotateSpeed = 15.0f;
    public float stickToGroundForce = 20.0f;
    public float speedLimitingForce = 1.0f;
    public float orthogonalDragForce = 10.0f;

    private Vector3 m_TargetDirection;
    private Vector3 m_TargetTurretDirection;
    private bool m_IsFlipping = false;
    private bool m_IsGrounded = false;
    private RaycastHit groundHitInfo;

    public Rigidbody PhysicsBody
    {
        get;
        private set;
    }

    public bool IsGrounded => m_IsGrounded;

    public Transform turret;

    private void Awake()
    {
        PhysicsBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        UpdatedIsGrounded();

        // Don't do movement if we are flipping
        if (m_IsFlipping) return;
        if (!m_IsGrounded) return;

        const float movingThreshold = 0.0002f;

        var moveDirection = Vector3.ProjectOnPlane(m_TargetDirection * tankAcceleration, groundHitInfo.normal);

        // Only rotate if we are moving
        if (m_TargetDirection.sqrMagnitude > movingThreshold)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection, Vector3.up);

            Quaternion slerpedRotation = Quaternion.Slerp(PhysicsBody.rotation, targetRotation, Time.fixedDeltaTime * rotateSpeed);

            PhysicsBody.MoveRotation(slerpedRotation);
        }

        PhysicsBody.AddRelativeForce(Vector3.down * stickToGroundForce);

        Vector3 force = transform.forward * moveDirection.magnitude; // Vector3.forward

        force = Vector3.ProjectOnPlane(force, groundHitInfo.normal);

        PhysicsBody.AddForceAtPosition(force * tankAcceleration, PhysicsBody.position, ForceMode.Acceleration);

        Vector3 orthogonalDragDirection = -Vector3.Project(PhysicsBody.velocity, transform.right);

        PhysicsBody.AddForce(orthogonalDragDirection * orthogonalDragForce, ForceMode.Acceleration);


        // Limit Velocity

        if (PhysicsBody.velocity.magnitude > maxSpeed)
        {
            float magnitude = PhysicsBody.velocity.magnitude - maxSpeed;
            Vector3 limitingForce = -PhysicsBody.velocity.normalized * magnitude;

            PhysicsBody.AddForce(limitingForce * speedLimitingForce, ForceMode.Acceleration);
        }
    }

    private void LateUpdate()
    {
        // Update the turret's position
        if (m_IsFlipping) return;

        Vector3 dir = transform.InverseTransformDirection(m_TargetTurretDirection);
        float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;

        turret.localEulerAngles = new Vector3(0, targetAngle, 0);
    }

    public void SetTargetDirection(Vector3 direction)
    {
        m_TargetDirection = direction.normalized;
    }

    public void SetTargetTurretPoint(Vector3 point)
    {
        Vector3 offset = point - turret.position;
        offset.y = 0;

        m_TargetTurretDirection = offset.normalized;
    }

    public void SetTargetTurretAngle(float angle)
    {
        float a = angle * Mathf.Deg2Rad;

        float x = Mathf.Cos(a);
        float y = Mathf.Sin(a);

        m_TargetTurretDirection = new Vector3(x, 0, y);
    }

    public void SetTargetTurretDirection(Vector2 direction)
    {
        m_TargetTurretDirection = direction.ToXZ().normalized;
    }

    public void SetLocalTargetTurretDirection(Vector3 direction)
    {
        m_TargetTurretDirection = transform.InverseTransformDirection(direction);
    }

    private bool CanFlip()
    {
        return GetVerticalAlignment() < 0.5f;
    }

    private float GetVerticalAlignment()
    {
        return Vector3.Dot(transform.up, Vector3.up);
    }

    private IEnumerator FlipTank()
    {
        m_IsFlipping = true;
        PhysicsBody.AddForce(Vector3.up * 3, ForceMode.VelocityChange);

        yield return new WaitForSeconds(0.1f);
        yield return new WaitForFixedUpdate();
        float startTime = Time.time;

        while (GetVerticalAlignment() < 0.99f && Time.time < startTime + 1.0f)
        {
            Quaternion current = PhysicsBody.rotation;
            Quaternion target = Quaternion.LookRotation(Vector3.forward, Vector3.up);

            Quaternion slerp = Quaternion.Slerp(current, target, Time.fixedDeltaTime * 5);

            PhysicsBody.MoveRotation(slerp);

            yield return new WaitForFixedUpdate();
        }
        PhysicsBody.angularVelocity = Vector3.zero;
        m_IsFlipping = false;
    }

    private void UpdatedIsGrounded()
    {
        Vector3 rayOrigin = transform.position + transform.up * 0.1f;
        m_IsGrounded = Physics.Raycast(rayOrigin, -transform.up, out groundHitInfo, groundedDistance);
    }

    public void Flip()
    {
        if (!m_IsFlipping && CanFlip())
        {
            StartCoroutine(FlipTank());
        }
    }
}
