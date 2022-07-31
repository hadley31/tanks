using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractiveObject<T>
{
    void OnInteraction(T obj);
}

public abstract class ObjectInteraction<T> : MonoBehaviour, IInteractiveObject<T>
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.TryGetComponent(out T p))
        {
            this.OnInteraction(p);
        }
    }

    public abstract void OnInteraction(T obj);
}