using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TankMovement))]
public abstract class TankInput : MonoBehaviour
{
    protected TankMovement m_Movement;
    protected TankShoot m_Shoot;


    protected void Awake()
    {
        m_Movement = GetComponent<TankMovement>();
        m_Shoot = GetComponentInChildren<TankShoot>();
    }
}
