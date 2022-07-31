using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Rigidbody rb;

    private void Update()
    {
        text.text = rb.velocity.magnitude.ToString("F2");
    }
}
