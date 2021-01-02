﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool isGrounded;
    public Vector3 jump;
    public int jumpCount;
    private Rigidbody self;



    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        jumpCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(moveX, 0f, moveY) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        if(isGrounded)
        {
            transform.Translate(moveX * Time.deltaTime * speed, 0, moveY * Time.deltaTime);
            if(Input.GetButtonDown("Jump"))
            {
                jumpCount = jumpCount + 1;
            self.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            }
            if(jumpCount == 2)
            {
                isGrounded = false;
                jumpCount = 0;                
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Start")
        {
            isGrounded = true;
        }
    }
    //
}