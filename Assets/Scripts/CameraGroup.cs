using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Cinemachine;

public class CameraGroup : MonoBehaviour
{
    private CinemachineTargetGroup targetGroup;

    private void Awake(){
        targetGroup = GetComponent<CinemachineTargetGroup>();
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach(var t in GameObject.FindObjectsOfType<TankMovement>().Select(x => x.transform)){
            targetGroup.AddMember(t, 1, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
