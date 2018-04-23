using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonPause : MonoBehaviour {

	public void QuitGame(){
		Application.Quit();
		Debug.Log("Quitting...");
	}
}
