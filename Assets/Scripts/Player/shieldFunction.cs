//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldFunction : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bullets")
            Destroy(collision.gameObject); 
        else if (collision.tag == "Boss")
        { }

        StartCoroutine("boostShield");  
    }

    IEnumerator boostShield ()
    {
        yield return new WaitForSeconds (3.0f);  
    
        this.gameObject.SetActive (false);
    }
}
