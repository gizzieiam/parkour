using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("WinnerUI").GetComponent<Text>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Finish")
        {
        GameObject.Find("WinnerUI").GetComponent<Text>().text = "Winner Winner \n Chicken Dinner";
        print(true);
        }
        
    }
}
