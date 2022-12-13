//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroyAfterTime : MonoBehaviour
{
    public float TimeToDestroy; 

    void Start()
    {
        Destroy(this.gameObject, TimeToDestroy);
    }
}
