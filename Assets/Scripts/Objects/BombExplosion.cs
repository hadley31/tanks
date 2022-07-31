using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    public void Boom(float radius)
    {

    }

    private IEnumerator DoExplosion()
    {
        while (transform.localScale.y < 5)
        {
            yield return null;
        }
        
    }
}
