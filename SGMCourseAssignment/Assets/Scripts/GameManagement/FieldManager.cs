using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnEnable()
    {
        GameManager.OnScore += ResetField;
       
    }

    void OnDisable()
    {
        GameManager.OnScore += ResetField;
    }


    void ResetField()
    {

    }
}
