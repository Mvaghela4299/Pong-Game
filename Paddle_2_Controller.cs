﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_2_Controller : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Padlle_2 Movement
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(0f, 10f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(0f, -10f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}
