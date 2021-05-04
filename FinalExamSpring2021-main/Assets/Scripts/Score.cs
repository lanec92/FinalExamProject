using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int score = 0;

    void Update()
    {
            scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        score++;
    }

    public void DeleteScore()
    {
        score--;
        if(score <= 0)
        {
            score = 0;
        }
    }
}
