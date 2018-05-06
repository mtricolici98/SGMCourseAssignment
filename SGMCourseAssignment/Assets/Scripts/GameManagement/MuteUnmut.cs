using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteUnmut : MonoBehaviour {


	private bool muted ;

	public Text buttonText;

	void Start(){
		buttonText = transform.FindChild ("Text").GetComponent<Text> ();
	}


	public void DisableAudio()
	{
		SetAudioMute( false ) ;
	}

	public void EnableAudio()
	{
		SetAudioMute( true ) ;
	}

	public void ToggleAudio()
	{
		if (muted) {
			DisableAudio ();
			buttonText.text = "Mute";

		}
		else if (muted == false) {
			
			EnableAudio ();
			buttonText.text = "Unmute";
		}
		

	
	} 

	private void SetAudioMute( bool mute )
	{
		AudioSource[] sources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		for( int index = 0 ; index < sources.Length ; ++index )
		{
			sources[index].mute = mute ;
		}
		muted = mute ;
	}
}
