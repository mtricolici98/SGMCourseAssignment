using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    //  private BoardManager boardScript;                     

    private int player1Score;
    private int player2Score;
    void Awake()
    {

        if (instance == null)


            instance = this;


        else if (instance != this)


            Destroy(gameObject);


        DontDestroyOnLoad(gameObject);


        InitGame();
    }


    void InitGame()
    {

        //  boardScript.SetupScene(level);
        player1Score = 0;
        player2Score = 0;
    }



    //Update is called every frame.
    void Update()
    {

    }

    void OnEnable()
    {
        ScoreManager.OnScoreL += ScoreL;
        ScoreManager.OnScoreR += ScoreR;
    } 

    void OnDisable()
    {
        ScoreManager.OnScoreL -= ScoreL;
        ScoreManager.OnScoreR -= ScoreR;
    }

    void ScoreL()
    {

    }

    void ScoreR()
    {

    }

}
