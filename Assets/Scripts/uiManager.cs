using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

    public Button[] buttons;
  
    bool gameOver;

	// Use this for initialization
	void Start () {

        gameOver = false;
      
	}
	
	// Update is called once per frame
	void Update () {
      
	}
    void scoreUpdate()
    {
        if(!gameOver)
        {
           // score += 1;
         
        }
      
    }
  
    public void gameOverActivated()
    {
        gameOver = true;

        if (Time.timeScale == 1) // if game is running
        {
            Time.timeScale = 0; // pause game
        }

        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
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
        if (Time.timeScale == 0) // if game is paused
        {
            Time.timeScale = 1; //resume game
        }
    }
    public void Replay()
    {
        Application.LoadLevel(Application.loadedLevel);
        if (Time.timeScale == 0) // if game is paused
        {
            Time.timeScale = 1; //resume game
        }
    }
    public void Menu()
    {
        Application.LoadLevel("MenuScene");
    }
    public void CheckScores()
    {
        Application.LoadLevel("ScoreScene");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
