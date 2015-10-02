using UnityEngine;
using System.Collections;

public class uiManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
}
