using UnityEngine;
using UnityEngine.UI;


public class PickLives : MonoBehaviour
{
    public Dropdown LifeDropDown;

    public static int playerLives;
    public static int recordLives;

    public void NumLives()
    {
        switch (LifeDropDown.value)
        {
            case 0:
                playerLives = 1;
                recordLives = 1;
                break;

            case 1:
                playerLives = 1;
                recordLives = 1;
                break;

            case 2:
                playerLives = 2;
                recordLives = 2;
                break;

            case 3:
                playerLives = 3;
                recordLives = 3;
                break;

            case 4:
                playerLives = 4;
                recordLives = 4;
                break;

            case 5:
                playerLives = 5;
                recordLives = 5;
                break;

            case 6:
                playerLives = 6;
                recordLives = 6;
                break;

            case 7:
                playerLives = 7;
                recordLives = 7;
                break;

            case 8:
                playerLives = 8;
                recordLives = 8;
                break;

            case 9:
                playerLives = 9;
                recordLives = 9;
                break;

            default:
                playerLives = 1;
                recordLives = 1;
                break;

        }
    }
}
