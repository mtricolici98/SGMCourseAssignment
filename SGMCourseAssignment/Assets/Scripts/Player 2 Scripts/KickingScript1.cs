using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickingScript1 : MonoBehaviour {

	Animator animator ;
RaycastHit2D hit;
Rigidbody2D rb;
public float force = 5f;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.RightShift)){
			animator.Play("kicking_anim",-1,0f);
            
            hit = Physics2D.Raycast(transform.position + transform.right, transform.right);
          
            Debug.Log("Raycasted with  " + hit.collider.gameObject.tag);
            if (hit.collider.gameObject.tag == "ball" && hit.distance < 1.5f)
            {
              
                Rigidbody2D ballrb = hit.collider.gameObject.GetComponent<Rigidbody2D>();
                ballrb.AddForce(transform.up * force, ForceMode2D.Impulse);
            }
        }
		}
	}
