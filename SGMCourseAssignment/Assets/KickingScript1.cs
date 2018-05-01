using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickingScript1 : MonoBehaviour {

	Animator animator ;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightShift)){
			animator.Play("kicking_anim",-1,0f);
		}
	}
}