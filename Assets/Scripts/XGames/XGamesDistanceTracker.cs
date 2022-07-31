using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class XGamesDistanceTracker : MonoBehaviour
{

    public TextMeshProUGUI text;
    private Transform m_Target;

    public void StartTracking(Transform t)
    {
        text.gameObject.SetActive(true);
        m_Target = t;
    }

    private void Update()
    {
        if (m_Target)
        {
            text.text = Vector3.Distance(transform.position, m_Target.position).ToString("F2");
        }
    }
}
