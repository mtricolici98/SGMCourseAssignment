﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    private float speed;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private bool rotated;
    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        speed = 7;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0f)
        {
            if (horizontal < 0f)
            {
                rb.AddForce(transform.right * speed );
                if (rotated == false)
                {
                    rb.transform.Rotate(0f, 180f, 0f);
                }
                rotated = true;
            } else if (horizontal > 0f)
            {
                rb.AddForce(transform.right * speed );
                if (rotated == true)
                {
                    rb.transform.Rotate(0f, 180f, 0f);
                }
                rotated = false;
            }



        }
           // rb.AddForce(transform.right * speed * horizontal);
       
    

    }
}
