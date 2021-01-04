using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Timer;
using static DeadZone;


public class Win : MonoBehaviour
{
    public static bool isOver = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("WinnerUI").GetComponent<Text>().text = "";
        GameObject.Find("WinInfoUI").GetComponent<Text>().text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if(isOver)
        {
            GameObject.Find("WinnerUI").GetComponent<Text>().color = Color.yellow;
            GameObject.Find("WinInfoUI").GetComponent<Text>().color = Color.yellow;
            GameObject.Find("WinnerUI").GetComponent<Text>().text = "Winner Winner \n Chicken Dinner";
            GameObject.Find("WinInfoUI").GetComponent<Text>().text = "You finished in " + FinishedTime + "\n You died " + deathCount + " times.";


        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Finish")
        {
            isOver = true;
        }
        
    }
}
