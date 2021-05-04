using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownController : MonoBehaviour
{
    // public int countdownTime;
    public Text countdownDisplay;
    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    IEnumerator CountdownToStart()
    {
        while(ShowVal.tryz >= 0)
        {
            countdownDisplay.text = ShowVal.tryz.ToString();

            yield return new WaitForSeconds(1f);

            ShowVal.tryz--;
        }
    }
}
