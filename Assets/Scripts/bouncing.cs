using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncing : MonoBehaviour
{
    public float min= -5f;
    public float max = 5f;

    private Rigidbody2D rb;

    public float topSpeed = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float randomSpeed = Random.Range(min, max);

        rb.velocity = new Vector2(randomSpeed, rb.velocity.y);


        if(rb.velocity.magnitude > topSpeed)
        {
            rb.velocity = rb.velocity.normalized * topSpeed;
        }
    }

  
}
