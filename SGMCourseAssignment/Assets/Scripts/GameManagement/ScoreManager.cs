using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {


    public delegate void ScoredL();
    public static event ScoredL OnScoreL;
    public delegate void ScoredR();
    public static event ScoredR OnScoreR;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "ball")
        {
            if (gameObject.tag == "GateP1")
            {
                OnScoreL();
            } else if (gameObject.tag == "GateP2")
            {
                OnScoreR();
            }
        } 
    }
}
