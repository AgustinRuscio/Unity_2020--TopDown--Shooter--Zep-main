//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPowerUpActivated : MonoBehaviour
{
    public GameObject shildGO;

    public void activateShield()
    {   
            shildGO.SetActive(true);   
    }
}
