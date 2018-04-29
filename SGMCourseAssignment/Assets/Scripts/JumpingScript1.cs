using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript1 : MonoBehaviour
{

    private float force;
    private Rigidbody2D rb;
    private int numberOfJumps;
    private Animator animator;
   
    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        numberOfJumps = 0;
        force = 6;
        animator = GetComponent<Animator>();
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            if (numberOfJumps < 2)
            {
                Invoke("jump", 0f);
                animator.SetBool("isInAir", true);
            }
        }
        
    }
    void LateUpdate()
    {
        if (rb.velocity.y < 0)
        {
            animator.SetBool("isInAir", false);
            animator.SetBool("isFalling", true);

        } else if(rb.velocity.y > 0) { 
            animator.SetBool("isInAir", true);
            animator.SetBool("isGoingIdle", false);

        } else if(rb.velocity.y == 0)
        {
            animator.SetBool("isFalling", false);
            animator.SetBool("isGoingIdle", true);
        }
    }

    void jump()
    {
        rb.AddForce(transform.up * force, ForceMode2D.Impulse);
        numberOfJumps++;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        Debug.Log("CollisionHappened");
        if (col.gameObject.tag == "GameField")
        {
            numberOfJumps = 0;
            animator.SetBool("isInAir", false);
            animator.SetBool("isFalling", false);
            animator.SetBool("isGoingIdle", true);
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "GameField")
        {
            numberOfJumps = 1;
        }

    }
}
