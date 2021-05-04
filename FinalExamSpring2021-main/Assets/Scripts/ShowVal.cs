using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowVal : MonoBehaviour
{
    public static int tryz = 30;
    public static int keepTime;
    // Start is called before the first frame update

    // Update is called once per frame
    public void textUpdate(float value)
    {
        tryz = Mathf.RoundToInt(value);
        keepTime = tryz;
    }
}
