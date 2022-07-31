using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAIController : TankInput
{
    private Vector3? m_TargetPosition;

    protected virtual void Update()
    {
        if (m_TargetPosition != null)
        {
            Vector3 direction = (Vector3)m_TargetPosition - transform.position;
            direction.y = 0;
            m_Movement.SetTargetDirection(direction);
        }
    }

    public void SetTargetPosition(Vector3? position)
    {
        m_TargetPosition = position;
    }
}
