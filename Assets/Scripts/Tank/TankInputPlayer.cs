using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankInputPlayer : TankInput
{
    private TankInputActions m_Input;

    private bool useController = false;

    private void OnEnable()
    {
        m_Input ??= new TankInputActions();
        m_Input.Movement.Enable();
        m_Input.Abilities.Enable();

        m_Input.Abilities.Shoot.performed += _ => m_Shoot.Shoot();
        m_Input.Movement.Flip.performed += _ => m_Movement.Flip();
    }

    private void OnDisable()
    {
        m_Input?.Movement.Disable();
        m_Input?.Abilities.Disable();
    }

    private void Update()
    {
        // var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            useController = !useController;
        }

        var input = m_Input.Movement.MoveDirection.ReadValue<Vector2>().ToXZ();
        m_Movement.SetTargetDirection(input);

        Plane plane = new Plane(transform.up, transform.position);

        Vector2 mousePos = Mouse.current.position.ReadValue();

        if (useController)
        {
            Vector2 turretTargetDirection = m_Input.Movement.TurretDirection.ReadValue<Vector2>();

            if (turretTargetDirection.sqrMagnitude >= 0.2f)
            {
                m_Movement.SetTargetTurretDirection(turretTargetDirection);
            }
        }
        else
        {
            Ray ray = Camera.main.ScreenPointToRay(mousePos);

            if (plane.Raycast(ray, out float enter))
            {
                Vector3 point = ray.GetPoint(enter);
                m_Movement.SetTargetTurretPoint(point);
            }
        }
    }
}