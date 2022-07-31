using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericSingletonMonobehaviour : MonoBehaviour
{
    private static readonly HashSet<Type> types = new HashSet<Type>();


    public bool Register(GenericSingletonMonobehaviour instance)
    {
        if (instance == null) return false;

        return types.Add(instance.GetType());
    }

    public bool UnRegister(GenericSingletonMonobehaviour instance)
    {
        if (instance == null) return false;

        return types.Remove(instance.GetType());
    }
}
