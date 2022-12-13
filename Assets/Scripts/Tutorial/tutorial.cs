//--------------------------------------
//              Ruscio&&Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public GameObject textoTutorial;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision!= null)
        {
            if (collision.tag == "Player")
                textoTutorial.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.tag == "Player")
                textoTutorial.SetActive(false);
        }
    }
}
