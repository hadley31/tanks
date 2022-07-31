using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class TankBoostAbility : MonoBehaviour
{
    ButtonControl control;
    public float boostForce = 100.0f;
    public float boostDuration = 2.0f;
    public float boostChargeSpeed = 1.0f;

    private float m_Boost;
    private bool m_IsBoosting;

    private TankInputActions m_Input;
    private Rigidbody m_Rigidbody;
    private TankMovement m_Movement;

    private void Awake()
    {
        m_Input = new TankInputActions();
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Movement = GetComponent<TankMovement>();
        m_Boost = 1.0f;
    }

    private void OnEnable()
    {
        m_Input.Abilities.Enable();

        // m_Input.Abilities.Boost.performed += i =>
        // {
        //     if (i.control.device is Gamepad)
        //     {

        //     }
        // };
    }

    private void OnDisable()
    {
        m_Input.Abilities.Boost.Disable();
    }

    private void Update()
    {
        bool pressed = m_Input.Abilities.Boost.ReadValue<float>() != 0;

        m_IsBoosting = pressed && CanBoost();

        if (!pressed && m_Boost < 1)
        {
            m_Boost = Mathf.Clamp01(m_Boost + Time.deltaTime * boostChargeSpeed);
        }
        else if (m_IsBoosting)
        {
            m_Boost = Mathf.Clamp01(m_Boost - Time.deltaTime / boostDuration);
        }
    }

    private void FixedUpdate()
    {
        if (m_IsBoosting && m_Movement.IsGrounded)
        {
            m_Rigidbody.AddRelativeForce(Vector3.forward * boostForce * m_Boost, ForceMode.Acceleration);
        }
    }

    private bool CanBoost()
    {
        return m_Boost > 0;
    }
}
