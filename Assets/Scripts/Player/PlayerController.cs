//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Weapon weapon;
    public new Camera camera;
    public int ammoReady;

    Vector2 moveDirection;
    Vector2 mousePosition;

    public Animator anim;
    public string movementSpeedParameterName = " movementSpeed ";
    public string shootParameterName = "shoot2";
    public BulletCounter bullentCounter;

    public AudioSource noBullet;
    public AudioSource Shoot;

    private void Start()
    {
        camera = Camera.main;  
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Fire1") && ammoReady > 0)
        {
            weapon.Fire();
            ammoReady--;

            Shoot.Play();

            bullentCounter.UpdateCounter(ammoReady);
            anim.SetTrigger(shootParameterName);
        }
        else if (Input.GetButtonDown("Fire1") && ammoReady <= 0)
        {
            Debug.Log("No tenes balas. Corré a buscar!");
            noBullet.Play();
        }

        if (moveDirection.magnitude > 1f)
        {
            moveDirection.Normalize();
        }

        anim.SetFloat("movementSpeed", moveDirection.magnitude);
        
        camera.gameObject.transform.position = this.transform.position - new Vector3(0, 0, 10);
        moveDirection = new Vector2(moveX, moveY);
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);     
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle       = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg + 10f;
        rb.rotation = aimAngle;
    }   
}
