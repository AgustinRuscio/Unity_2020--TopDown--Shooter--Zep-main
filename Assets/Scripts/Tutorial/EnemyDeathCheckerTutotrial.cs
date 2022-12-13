//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathCheckerTutotrial : MonoBehaviour
{
    public GameObject textoAnterior;
    public GameObject textoSiguiente;

    public GameObject[] paredes;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision != null)
            if (collision.tag == "Enemigo")
            {
                textoAnterior.SetActive(false);
                textoSiguiente.SetActive(true);

                Destroy(paredes[0]);
                Destroy(paredes[1]);
            }
    }
}
