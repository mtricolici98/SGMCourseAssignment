using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickingScript : MonoBehaviour {

Animator animator ;
RaycastHit2D hit;
Rigidbody2D rb;
public float force = 5f;
public GameObject ball;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		//ball = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
         
	}

		if(Input.GetKeyDown(KeyCode.LeftShift)){
			animator.Play("kicking",-1,0f);
            // Debug.Log("Space Hit");
            hit = Physics2D.Raycast(transform.position + transform.right, transform.right);
            // Debug.Log("Transform right " + transform.right);
            //  Debug.DrawLine(transform.position + transform.right, transform.right, Color.red, 10f);
            Debug.Log("Raycasted with  " + hit.collider.gameObject.tag);
            if (hit.collider.gameObject.tag == "ball" && hit.distance < 1f)
            {
                //Debug.Log("Distance : " + hit.distance);
                //Debug.Log("RayCasted with  " + hit);
                Rigidbody2D ballrb = hit.collider.gameObject.GetComponent<Rigidbody2D>();
                ballrb.AddForce(transform.up * force, ForceMode2D.Impulse);
            }
        }
		}
	}

