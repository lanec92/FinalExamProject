using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameManager gm;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        Debug.Log("Game Saved!");
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Debug.Log("Loaded Game w/" + data.currScore + " " + data.currLives);
        Score.score = data.currScore;
        PickLives.playerLives = data.currLives;
        ShowVal.tryz = data.currTime;
    }

    public void SaveAsJSON()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        string json = JsonUtility.ToJson(data);
        Debug.Log("Saving as JSON: " + json);
    }
}
