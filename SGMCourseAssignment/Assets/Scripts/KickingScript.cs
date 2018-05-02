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
		if(Input.GetKeyDown(KeyCode.Space)){
			hit = Physics2D.Raycast(transform.position + new Vector3(1f,1f,0f),ball.transform.position);
			Debug.DrawLine(transform.position,ball.transform.position, Color.red , 10f);
			if(hit.collider.gameObject.tag == "ball"){
			 Rigidbody2D ballrb = ball.GetComponent<Rigidbody2D>();	
			 ballrb.AddForce(new Vector3(50f,50f,0f));
			}
	}

		if(Input.GetKeyDown(KeyCode.LeftShift)){
			animator.Play("kicking",-1,0f);
			
		}
		}
	}

