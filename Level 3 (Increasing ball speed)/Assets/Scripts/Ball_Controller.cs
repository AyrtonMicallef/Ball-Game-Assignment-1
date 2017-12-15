using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 vel;
    private bool hasStarted = false;
    Rigidbody rb;
    

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            rb2d.velocity = vel;
        }
    }
    void Update()
    {

        if (!hasStarted) //if hasStarted == false
            {
            if (Input.GetMouseButtonDown(0)) // left click
            {
                hasStarted = true;
                //applies a velocity of 2x
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(7f, 2f);
            }
        }
    }
    
}