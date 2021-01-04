using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void OnTriggerEnter(Collider other)
    {
        // Destroy(other.gameObject);
        deathCount = deathCount + 1;
        player.transform.position = respawnPoint.transform.position;

    }
}
