using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
		gameEnded = false;
	}
	void Ended(){
		gameEndedUI.SetActive(true);
		gameEnded = true;
	}
	public void NewGameButton(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		notEnded();
	}

	public void QuitButton(){
		Application.Quit();
		Debug.Log("Quitting game...");
	}
}
