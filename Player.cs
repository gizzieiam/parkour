using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DeadZone;

public class Player : MonoBehaviour
{
    public static int Health;
    public static bool isDead;
    // Start is called before the first frame update
    void Start()    
    {
        Health = 3;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead)
        {
            deathCount = deathCount + 1;
        }
    }
}

