using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int currScore;
    public int currLives;
    public int currTime;
    public PlayerData(GameManager gm)
    {
        currLives = PickLives.playerLives;
        currScore = Score.score;
        currTime = ShowVal.tryz;
    }
}