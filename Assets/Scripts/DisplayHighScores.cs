using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighScores : MonoBehaviour {
   
    public Text[] highscoreFields;
    highScores highscoresManager;

    void Start()
    {
        for (int i = 0; i < highscoreFields.Length; i++)
        {
            highscoreFields[i].text = i + 1 + ". ";
        }


        highscoresManager = GetComponent<highScores>();
        StartCoroutine("RefreshHighscores");
    }
    IEnumerator RefreshHighscores()
    {
        while (true)
        {
            highscoresManager.DownloadHighscores();
            yield return new WaitForSeconds(30);
        }
    }
    public void OnHighscoresDownloaded(Highscore[] highscoreList) //Highscore struct
    {
        for (int i = 0; i < highscoreFields.Length; i++)
        {
            highscoreFields[i].text = i + 1 + ". ";
            if (i < highscoreList.Length)
            {
                highscoreFields[i].text += highscoreList[i].username + " --- " + highscoreList[i].score;
            }
        }
    }

  
     
}
