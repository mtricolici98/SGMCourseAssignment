using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript1 : MonoBehaviour
{
    [SerializeField] private float speed;
    private Animator animator;
    private Rigidbody2D rb;
 
    private bool rotated;
    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
      
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal1");
        
        if (horizontal != 0f)
        {
            animator.SetFloat("speed1", speed);
            if (horizontal > 0f)
            {
                rb.AddForce(-transform.right * speed);
                if (rotated == false)
                {
                    rb.transform.Rotate(0f, 180f, 0f);
                }
                rotated =  true;
            }
            else if (horizontal < 0f)
            {
                rb.AddForce(-transform.right * speed);
                if (rotated == true)
                {
                    rb.transform.Rotate(0f, 180f, 0f);
                }
                rotated = false;
            }



        }
        else
        {
            animator.SetFloat("speed1", 0);
        }
        // rb.AddForce(transform.right * speed * horizontal);



    }
}