using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    private Text textObj;
    public float delay;

   
    IEnumerator Start()
    {
        //Counts down from 5 upon playing
        textObj = GetComponent<Text>();
        textObj.text = "5";
        var i = 5;
        while (i > 0)
        {
            textObj.text = i.ToString();
            yield return new WaitForSeconds(delay);
            i--;
        }
        textObj.text = "BEGIN!";
        yield return new WaitForSeconds(delay);
        textObj.text = "";
        
        //Insert Countdown Fader?
    }
}

