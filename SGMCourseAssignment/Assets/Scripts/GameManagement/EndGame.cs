using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {
    public delegate void NewGame();
    public static event NewGame onNewGame;
    public delegate void ResetTimer();
    public static event ResetTimer resetTimer;
    [HideInInspector]    public GameObject gameEndedUI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(FindObjectOfType<timer>().timeLeft <= 0){
            Invoke("Ended", 0f);
		}	
		else{
            Invoke("notEnded", 0f);
         
		}
	}

	public void notEnded(){
		gameEndedUI.SetActive(false);
		//Time.timeScale = 1f;
		
	}
	void Ended(){
		gameEndedUI.SetActive(true);
		//Time.timeScale = 0f;
	}
	public void NewGameButton(){

        resetTimer();
    
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        onNewGame();
		Invoke("notEnded", 0f);
        Debug.Log("NewGame");
    }

	public void QuitButton(){
		Application.Quit();
		Debug.Log("Quitting game...");
	}
}
