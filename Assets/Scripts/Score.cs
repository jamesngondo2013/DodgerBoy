using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    
    public Text scoreText;
    public int dollarValue;
    private int score;

	// Use this for initialization
	void Start () {

        score = 0;
        UpdateScore();
	}
	
	// Update is called once per frame
	void UpdateScore () {

        //scoreText.text = "Score:\n" + score;
	}

    void OnCollisionEnter2D()
    {
        score += dollarValue;
        UpdateScore();
    }
     
}
