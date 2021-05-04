using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumLives : MonoBehaviour
{
    public Text livesText;

    void Awake()
    {
        if (PickLives.playerLives == 0)
        {
            PickLives.playerLives += 1;
            livesText.text = PickLives.playerLives.ToString();
        }
        else
        {
            livesText.text = PickLives.playerLives.ToString();
        }
    }

    private void Update()
    {
        livesText.text = PickLives.playerLives.ToString();
    }

    public void AddLives()
    {
        PickLives.playerLives++;
        if(PickLives.playerLives >= 9)
        {
            PickLives.playerLives = 9;
        }
    }

    public void DeleteLives()
    {
        PickLives.playerLives--;

        if(PickLives.playerLives <= 0)
        {
            PickLives.playerLives = 0;
        }
    }
}
