﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickingScript : MonoBehaviour {

Animator animator ;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftShift)){
			animator.Play("kicking",-1,0f);
		}
	}
}
