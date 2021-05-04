﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public InputField playername;
    public void PlayGame()
    {
        Debug.Log("playerName is :" + playername.text);
        PlayerName.playernamestr = playername.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
