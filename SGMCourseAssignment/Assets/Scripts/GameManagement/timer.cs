using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text timerText;
	public int initTime = 180;
    public int timeLeft;



	// Use this for initialization
	void Start () {
        timeLeft = initTime;
        StartCoroutine ("LoseTime");
       
	}

    void OnEnable()
    {
        EndGame.resetTimer += ResetTimer;
    }

    void OnDisable()
    {
       EndGame.resetTimer -= ResetTimer;
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

    public void ResetTimer()
    {
      
        timeLeft = initTime;
        StartCoroutine("LoseTime");
    }
}
