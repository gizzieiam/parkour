using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public float timer;
    public Transform[] moveSpot;
    public float startWaitTime;
    private int randomSpot;


    // Start is called before the first frame update
    void Start()
    {
        randomSpot = Random.Range(0, moveSpot.Length);        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot[randomSpot].position, speed * Time.deltaTime);    

        if(Vector2.Distance(transform.position, moveSpot[randomSpot].position) < 0.2f) 
            {
                randomSpot = Random.Range(0, moveSpot.Length);
            }
    }
}
