using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class TransformUnityEvent : UnityEvent<Transform> { }

public class XGamesStartTrigger : MonoBehaviour
{
    public TransformUnityEvent onStart;

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<TankMovement>())
        {
            onStart.Invoke(collider.transform);
        }
    }
}
