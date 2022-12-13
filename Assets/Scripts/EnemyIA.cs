//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyIA : MonoBehaviour
{
    public Transform  target;

    public float nextWaypointDistance   = 3f;
    public float speed                  = 200f;

    private Path path;
    private Seeker seeker;

    private int currentWaypoint = 0;

    private bool reachEndOfpath;
    public bool finderActivated;

    private Rigidbody2D myRigidBody;

    void Start()
    {
        seeker = GetComponent<Seeker>();
        myRigidBody = GetComponent<Rigidbody2D>();
        target = FindObjectOfType<PlayerController>().gameObject.transform;

        InvokeRepeating("UpdatePath", 0f, 0.5f);
    }

    void UpdatePath()
    {
        if (seeker.IsDone())
            seeker.StartPath(myRigidBody.position, target.position, OnPathComplete); 
    }

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            this.path       = p;
            currentWaypoint = 0;
        }
    }

    void FixedUpdate()
    {
        if (finderActivated)
        {
            if (path == null)
                return;

            if (currentWaypoint >= path.vectorPath.Count)
            {
                reachEndOfpath = true;
                return;
            }
            else
                reachEndOfpath = false;

            Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - myRigidBody.position).normalized;
            Vector2 force = direction * speed * Time.deltaTime;

            myRigidBody.AddForce(force);

            float distance = Vector2.Distance(myRigidBody.position, path.vectorPath[currentWaypoint]);

            if (distance < nextWaypointDistance)
                currentWaypoint++;
        }
    }
}
