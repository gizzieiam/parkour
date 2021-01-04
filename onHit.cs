using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player;

public class onHit : MonoBehaviour
{
    public static bool isSmashed;
    public bool isHit;
    public CameraShake cameraShake;

    // Start is called before the first frame update
    void Start()
    {
        isSmashed = false;
        isHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isHit == true)
        {
            StartCoroutine(cameraShake.Shake(0.15f, 0.4f));
            isHit = false;
        }
    }
    

    void OnCollisionEnter(Collision col)
    {
        string label = col.gameObject.tag;
        if (label == "Blade")
        {
            Health = Health - 1;
            isHit = true;
        }

        if(label == "B1"){
            isSmashed = true;
            isHit = true;
        }

        
    }
}
