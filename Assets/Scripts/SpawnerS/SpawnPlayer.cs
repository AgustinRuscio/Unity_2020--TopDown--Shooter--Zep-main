//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform spwanPoint;

    void Start()
    {
        Instantiate(player,spwanPoint.position, spwanPoint.rotation);
    } 
}
