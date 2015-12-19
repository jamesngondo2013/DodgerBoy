using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
    private string username;
    private static int theScore;
    Score myScore;
	// Use this for initialization
	void Start () {
        //username = "Anonymous";
        //theScore = Score.totalScore;

        //highScores.AddNewHighscore(username, theScore);

        //print(username + "" + theScore);
	}
	
	// Update is called once per frame
	void Update () {
        username = "Anonymous";
        theScore = Score.totalScore;

        highScores.AddNewHighscore(username, theScore);

        //print(username + "" + theScore);
        /*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int score = Random.Range(0, 2000);
            string username = "";
            string alphabet = "abcdefghijklmnopqrstuvwyz";

            for(int i=0; i<Random.Range(5,10);i++)
            {
                username += alphabet[Random.Range(0, alphabet.Length)];

            }
            //username = login.getName();
            highScores.AddNewHighscore(username, score);
        }
         */
	}
   
    
}
