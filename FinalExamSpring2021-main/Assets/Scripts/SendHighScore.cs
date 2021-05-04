using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SendHighScore : MonoBehaviour
{
    public void sendData()
    {
        HighScoreTable.AddHighscoreEntry(Score.score, PlayerName.playernamestr);
        SceneManager.LoadScene(2);
    }
}
