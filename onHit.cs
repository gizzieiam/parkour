using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player;

public class onHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Health == 0)
        {
            // deathCount = deathCount + 1;
            // player.transform.position = respawnPoint.transform.position;

        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Blade")
        {
            Health = Health - 1;
        }
        
    }
}
