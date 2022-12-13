//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtObject : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        target = FindObjectOfType<PlayerController>().transform;

        this.transform.right = target.position - this.transform.position;  
    }
}
