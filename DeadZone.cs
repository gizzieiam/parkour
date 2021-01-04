using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player;
using static onHit;

public class DeadZone : MonoBehaviour
{
    // Start is called before the first frame update
    public static int deathCount;
    public Transform player;
    public Transform respawnPoint;
    void Start()
    {
        deathCount = 0;
    }

    void Update()
    {
        onDeath();
    }
    void onDeath()
    {
        if(Health == 0 || isSmashed)
        {
            deathCount = deathCount + 1;
            player.transform.position = respawnPoint.transform.position;
            Health = 3;
            isSmashed = false;

        }

    }
    void OnTriggerEnter(Collider other)
    {
        // Destroy(other.gameObject);
        deathCount = deathCount + 1;
        Health = 3;
        player.transform.position = respawnPoint.transform.position;

    }
}
