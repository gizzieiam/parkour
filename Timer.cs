using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Win;

public class Timer : MonoBehaviour
{
    public float time;
    public int minutes;
    public int seconds;
    public string timer;
    public static string FinishedTime;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        //show time on screen
        GameObject.Find("TimerUI").GetComponent<Text>().text ="";
    }

    // Update is called once per frame
    void Update()
    {

        if(isOver)
        {
            FinishedTime = timer;
        }else{
            time = time + Time.deltaTime;// Time.deltaTime (allow variable to update every sec) no matter the frame rate
            seconds = (int) (time%60); // convert time to only seconds not milliseconds
            minutes = (int) (time/60); // minutes
            timer =  minutes + "m " + seconds  + "s";
        }
        //update time message
        GameObject.Find("TimerUI").GetComponent<Text>().text = timer;
    }
}
