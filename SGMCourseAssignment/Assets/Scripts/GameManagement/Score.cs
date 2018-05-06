using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {
	public delegate void ScoredL();
	public static event ScoredL OnScoreL;
	public delegate void ScoredR();
	public static event ScoredR OnScoreR;
	private int leftOneScore=0;
	private int rightOneScore=0;
	public GameObject ball;

	public Text text;

	// Use this for initialization
	void Start () {


		
	}
	void Update () {
		text.text = leftOneScore.ToString () + " - " + rightOneScore.ToString ();
	}
	void OnEnable()
	{
		ScoreManager.OnScoreL += ScoreL;
		ScoreManager.OnScoreR += ScoreR;
        EndGame.onNewGame += Reset;
    } 

	void OnDisable()
	{
		ScoreManager.OnScoreL -= ScoreL;
		ScoreManager.OnScoreR -= ScoreR;
        EndGame.onNewGame -= Reset;
    }

	public void ScoreL()
	{
		leftOneScore++;
	//	Update ();


	}

	public void ScoreR()
	{
		rightOneScore++;
	//	Update ();


	}

    void Reset()
    {
 
        leftOneScore = 0;
        rightOneScore = 0;
    }


    // Update is called once per frame

    //	text.text = leftOneScore.ToString () + " - " + rightOneScore.ToString ();


}
