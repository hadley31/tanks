using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Bomb : MonoBehaviour
{
    private const float DISABLED_FUSE = -1f;

    public float fuseTimer = 10.0f;
    public float radius = 5.0f;
    public float explosionForce = 100.0f;
    public float maxDamage = 1000.0f;
    public bool lightOnStart = true;

    public UnityEvent preExplosion;
    public UnityEvent onExplode;

    private float m_FuseStartTime = DISABLED_FUSE;
    private bool m_Exploded = false;

    public bool FuseLit => m_FuseStartTime >= 0;

    private void Start()
    {
        if (lightOnStart) StartFuse();
    }

    private void Update()
    {
        if (FuseLit && Time.time > m_FuseStartTime + fuseTimer)
        {
            Explode();
        }
    }

    public void StartFuse()
    {
        m_FuseStartTime = Time.time;
    }

    public void StopFuse()
    {
        m_FuseStartTime = DISABLED_FUSE;
    }

    public void Explode()
    {
        // If we have already exploded, do nothing.
        if (m_Exploded) return;

        preExplosion.Invoke();

        var colliders = Physics.OverlapSphere(transform.position, radius);
        var rigidbodies = new HashSet<Rigidbody>(colliders.Where(x => x.attachedRigidbody).Select(x => x.attachedRigidbody));

        foreach (var rb in rigidbodies)
        {
            // TODO Deal damage
            rb.AddExplosionForce(explosionForce, transform.position, radius, 2f, ForceMode.Force);
            print($"Affected {rb.name}");
        }


        onExplode.Invoke();

        // Set the exploded flag
        m_Exploded = true;

        // Destroy the gameobject
        Destroy(gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, this.radius);
    }
}
