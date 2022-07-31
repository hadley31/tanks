using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int m_Health;
    [SerializeField] private int m_MaxHealth = 100;
    [SerializeField] private bool m_SetToMaxOnAwake = true;

    public int Value
    {
        get => m_Health;
        set => m_Health = value;
    }

    private void Awake()
    {
        m_Health = m_SetToMaxOnAwake ? m_MaxHealth : m_Health;
    }
}
