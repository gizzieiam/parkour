using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    // Start is called before the first frame update
    public static int deathCount;
    void Start()
    {
        deathCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Destory(other.gameObject);
    }
    // void OnTriggerEnter(Collider other)
    // {

    // }
}
