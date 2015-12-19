using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    
    public Text scoreText;
    public int dollarValue;
    public static int score;
    public static int totalScore;
    private static string username = "Anonymous";

	// Use this for initialization
	void Start () {

        score = 0;
        UpdateScore();
	}
    void Update()
    {
       // highScores.AddNewHighscore(username, score);
    }
	
	
	// Update is called once per frame
	void UpdateScore () {

        scoreText.text = "" + score;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ghost Skull")
        {
            UpdateScore();
        }
        else 
        {
            score += dollarValue;
            totalScore = score;
            UpdateScore();
           // highScores.AddNewHighscore(username, totalScore);
            print(username + "" + totalScore);
            
        }
    }
    public int getScore()
    {
        return score;
    }
   
}
