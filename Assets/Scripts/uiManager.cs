using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

    public Text scoreText;
    int score;
    bool gameOver;

	// Use this for initialization
	void Start () {

        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate",1.5f, 1.0f);

       
	}
	
	// Update is called once per frame
	void Update () {

        scoreText.text = "Score:\n" + score;
      
	}
    void scoreUpdate()
    {
        if(!gameOver)
        {
            score += 1;
        }
      
    }
    public void GameOver()
    {
        gameOver = true;
    }
    public void Pause()
    {
        if(Time.timeScale ==1) // if game is running
        {
            Time.timeScale = 0; // pause game
        }
        else if (Time.timeScale == 0) // if game is paused
        {
            Time.timeScale = 1; //resume game
        }
    }
    public void Play()
    {
        Application.LoadLevel("Main");
    }
    public void Replay()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void Menu()
    {
        Application.LoadLevel("MenuScene");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
