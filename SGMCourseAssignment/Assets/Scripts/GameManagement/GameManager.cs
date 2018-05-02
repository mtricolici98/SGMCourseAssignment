using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public delegate void Scored();
    public static event Scored OnScore;
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
        player1Score++;
        Debug.Log("Plyaer 1 Score " + player1Score);
      
        OnScore();
    }

    void ScoreR()
    {
        player2Score++;
        Debug.Log("Plyaer 2 Score " + player2Score);
        OnScore();
    }

}
