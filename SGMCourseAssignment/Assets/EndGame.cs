using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

	public static bool gameEnded = false;
	public GameObject gameEndedUI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(FindObjectOfType<timer>().timeLeft <= 0){
			Ended();
		}	
		else{
			notEnded();
		}
	}

	public void notEnded(){
		gameEndedUI.SetActive(false);
		Time.timeScale = 1f;
		gameEnded = false;
	}
	void Ended(){
		gameEndedUI.SetActive(true);
		Time.timeScale = 0f;
		gameEnded = true;
	}
}
