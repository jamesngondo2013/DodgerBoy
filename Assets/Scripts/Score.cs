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
            UpdateScore();
        }
    }
   
}
