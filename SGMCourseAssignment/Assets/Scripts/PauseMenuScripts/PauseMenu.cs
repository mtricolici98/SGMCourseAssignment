using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	public static bool gamePaused = false;
	public GameObject pauseMenuUI;
    public GameObject result;
    public GameObject timer;


	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(gamePaused){
				Resume();
			}
			else{
				Pause();
			}
		}
	}
	public void Resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
        Debug.Log("TimeScale" + Time.timeScale);
		gamePaused = false;
        timer.SetActive(true);
        result.SetActive(true);

    }
	void Pause(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
        Debug.Log("TimeScale" + Time.timeScale);
        gamePaused = true;
        timer.SetActive(false);
        result.SetActive(false);
	}

	public void MenuButton(){
		SceneManager.LoadScene("MenuStart");
	}

	public void QuitButton(){
		Application.Quit();
		Debug.Log("Quitting game...");
	}
	
}
