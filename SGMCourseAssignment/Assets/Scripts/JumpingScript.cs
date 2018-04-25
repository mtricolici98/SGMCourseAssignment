using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.W))
        {

            if (numberOfJumps < 2)
            {

                animator.SetBool("isInAir", true);
                Invoke("jump", 0f);

            }

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
        }
    }
}
