using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Pool;


public class Projectile : MonoBehaviour, IResettable
{
    [SerializeField] private int m_MaxBounces = 1;
    [SerializeField] private float m_Speed = 6.0f;
    [SerializeField] private int m_Damage = 100;
    [SerializeField] private UnityEvent onDestroy;

    private Vector3 m_Direction;
    private Rigidbody m_Rigidbody;

    public Vector3 Velocity => m_Direction * m_Speed;

    public int RemainingBounces
    {
        get; private set;
    }

    public Vector3 Direction
    {
        get => m_Direction;
        set => m_Direction = value.normalized;
    }

    public int Damage
    {
        get => m_Damage;
        set => m_Damage = value;
    }

    private void Awake()
    {
        m_Direction = transform.forward;
        m_Rigidbody = GetComponent<Rigidbody>();
        RemainingBounces = m_MaxBounces;
    }

    private void FixedUpdate()
    {
        Vector3 newPosition = m_Rigidbody.position + Velocity * Time.fixedDeltaTime;
        m_Rigidbody.MovePosition(newPosition);
        m_Rigidbody.MoveRotation(Quaternion.LookRotation(Velocity, Vector3.up));
    }

    public bool Bounce(Vector3 normal)
    {
        if (RemainingBounces-- <= 0)
        {
            return false;
        }

        m_Direction = Vector3.Reflect(m_Direction, normal);
        return true;
    }

    public void Reset()
    {
        this.gameObject.SetActive(false);
        m_Rigidbody.velocity = Vector3.zero;
    }
}
