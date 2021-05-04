using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void Replay()
    {
        //Back to default
        Score.score = 0;
        ShowVal.tryz = 30;
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
        //EditorApplication.isPlaying = false; //Exit in editor
    }


}
