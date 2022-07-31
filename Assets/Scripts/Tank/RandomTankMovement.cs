using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TankMovement))]
public class RandomTankMovement : TankAIController
{
    public float perlinResolution = 0.02f;

    protected override void Update()
    {
        float x = Mathf.PerlinNoise(0, Time.time * perlinResolution) * 2 - 1;
        float z = Mathf.PerlinNoise(Time.time * perlinResolution, 0) * 2 - 1;

        Vector3 direction = new Vector3(x, 0, z);

        m_Movement.SetTargetDirection(direction);
    }
}
