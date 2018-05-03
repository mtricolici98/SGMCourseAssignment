using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text timerText;
	public int timeLeft = 180;




	// Use this for initialization
	void Start () {
		StartCoroutine ("LoseTime");
		
	}

	
	// Update is called once per frame
	void Update () {
		timerText.text = (timeLeft/60 + ":" + timeLeft%60 );

		if (timeLeft <= 0) {
			StopCoroutine ("LoseTime");
			timerText.text = "Times Up!";
		}
		
	}


	IEnumerator LoseTime(){

		while (true) {
			yield return new WaitForSeconds (1);
			timeLeft--;
		}
	}
}
