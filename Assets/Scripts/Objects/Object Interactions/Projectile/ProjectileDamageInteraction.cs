using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class ProjectileDamageInteraction : ObjectInteraction<Projectile>
{
    public float damageMultiplier = 1.0f;
    private Health m_Health;

    private void Awake()
    {
        m_Health = GetComponent<Health>();
    }

    public override void OnInteraction(Projectile p)
    {
        m_Health.Value -= (int)(2 * damageMultiplier);
    }
}