﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
{

    private float force;
    private Rigidbody2D rb;
    private int numberOfJumps;
    private Animator animator;
    private float lastPos;
    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        numberOfJumps = 0;
        force = 6;
        animator = GetComponent<Animator>();
        lastPos = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.W))
        {

            if (numberOfJumps < 2)
            {


                Invoke("jump", 0f);

            }

        }
        lastPos = gameObject.transform.position.y;
    }
    void LateUpdate()
    {
        if (lastPos < gameObject.transform.position.y)
        {
            animator.SetBool("isInAir", true);
            animator.SetBool("isFalling", false);
            animator.SetBool("isRunningSlow", false);
        }
        if (lastPos > gameObject.transform.position.y)
        {
            animator.SetBool("isFalling", true);
            animator.SetBool("isRunningSlow", false);
        }
        if (lastPos == gameObject.transform.position.y)
        {
            animator.SetBool("isInAir", false);
            animator.SetBool("isFalling", false);
            animator.SetBool("isRunningSlow", true);
        }

    }

    void jump()
    {
        rb.AddForce(transform.up * force, ForceMode2D.Impulse);
        numberOfJumps++;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        animator.SetBool("isInAir", false);
        animator.SetBool("isFalling", false);
        animator.SetBool("isRunningSlow", true);
        Debug.Log("CollisionHappened");
        if (col.gameObject.tag == "GameField")
        {
            numberOfJumps = 0;

        }
    }
}
