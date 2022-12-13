//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoIncreaser : MonoBehaviour
{
    public int ammoToSum;

    public BoxCollider2D boxCollider;

    public AudioSource ammoSource;  
    public AudioClip ammoClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ammoSource.Play();
        StartCoroutine(waitforsound(ammoClip));

        collectAmmo ColectItems = collision.gameObject.GetComponent<collectAmmo>();
        ColectItems.IncreaseAmmo(ammoToSum);
        Debug.Log(" Agarraste " + ammoToSum);     
    }    

    public IEnumerator waitforsound(AudioClip sound)
    {
        boxCollider.enabled = false;
        yield return new WaitUntil(() => ammoSource.isPlaying == false);
        gameObject.SetActive(false);

        Destroy(this.gameObject);
    }
}