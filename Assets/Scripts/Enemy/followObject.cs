//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followObject : MonoBehaviour
{
    public Transform target;

    public float MaxmovementSpeed;
    Vector3 newPositionVector;
    float startingZ;

    void Update()
    {
        target = FindObjectOfType<PlayerController>().transform;

        newPositionVector = Vector2.MoveTowards(transform.position, target.position, MaxmovementSpeed * Time.deltaTime);
        newPositionVector.z = this.transform.position.z;
        this.transform.position = newPositionVector; 
    }
}