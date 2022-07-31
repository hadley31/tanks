using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroyInteraction : ObjectInteraction<Projectile>
{
    public bool destroyProjectile = true;

    public override void OnInteraction(Projectile p)
    {
        Destroy(gameObject);

        if (destroyProjectile)
        {

        }
    }
}
