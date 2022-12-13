using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCloseAudio : MonoBehaviour
{
    public AudioSource doorClose;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(doorClose != null)
            doorClose.Play();      
    }
}
