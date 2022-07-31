using UnityEngine;
using System.Linq;

public static class Vector2Extensions
{
    public static Vector3 ToXZ(this Vector2 a)
    {
        return new Vector3(a.x, 0, a.y);
    }
}