using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pool;

public class ProjectileManager : MonoBehaviour
{
    public static ProjectileManager Instance
    {
        get;
        private set;
    }
    public Projectile projectilePrefab;

    private Pool<Projectile> pool;

    private void Awake()
    {
        Instance = this;
        pool = new Pool<Projectile>(new PrefabFactory<Projectile>(projectilePrefab), 5);
    }

    public Projectile Spawn(Vector3 position, Vector3 direction)
    {
        var proj = pool.Allocate();

        proj.transform.position = position;
        proj.Direction = direction;
        proj.gameObject.SetActive(true);

        return proj;
    }

    public void Despawn(Projectile p)
    {
        pool.Release(p);
    }
}
