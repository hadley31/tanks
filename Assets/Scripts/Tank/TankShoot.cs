using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public Projectile projectilePrefab;
    public Transform projectileSpawnPoint;

    public void Shoot()
    {
        Vector3 spawnPoint = projectileSpawnPoint.position;
        Vector3 direction = projectileSpawnPoint.forward;
        ProjectileManager.Instance.Spawn(spawnPoint, direction);
    }
}
