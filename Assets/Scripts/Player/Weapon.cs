//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform firePoint;
    public Transform firePoint1;
    public Transform firePoint2;

    public float fireForce = 20f;

    public void Fire () 
    {
        int numero = Random.Range(0, 3);

        if(numero == 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        else if(numero == 1)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        else if (numero == 2)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
    }
}
