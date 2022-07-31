using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTurret : MonoBehaviour
{

    public float rotateLerpSpeed = 15.0f;

    private float m_TargetRotation = 0.0f;

    //
    // Summary:
    //     Sets the target heading direction of the turret.
    //
    // Parameters:
    //     direction: The new target direction in world space.
    public void SetTargetDirection(Vector3 direction)
    {
        float angle = Mathf.Atan2(direction.z, direction.x);

        m_TargetRotation = angle;
    }

    //
    // Summary:
    //     Sets the target heading direction of the turret.
    //
    // Parameters:
    //     direction: The new target point in world space.
    public void SetTargetPoint(Vector3 point)
    {
        var offset = point - transform.position;

        SetTargetDirection(offset);
    }


    public void Rotate(float delta)
    {
        m_TargetRotation += delta;
    }

    // private void LateUpdate()
    // {
    //     var current = transform.rotation;
    //     var target = Quaternion.Euler(0, m_TargetRotation, 0);

    //     // Calculate an interpolated rotation between the current and target
    //     var rotation = Quaternion.Slerp(current, target, Time.deltaTime * rotateLerpSpeed);

    //     // Update the transforms rotation
    //     transform.rotation = rotation;
    // }
}
