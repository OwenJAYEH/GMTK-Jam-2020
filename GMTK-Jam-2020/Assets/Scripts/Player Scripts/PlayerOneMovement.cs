﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour
{
    // Initialized public variables for use inside of the inspector
        public PlayerOneCharacterController2D controller;

    // Initialized variables
        // Variable for player run speed
        public float runSpeed = 100f;
        // Variable used for player movement left and right
        float horizontalMove = 0f;
    
    // Booleans for Jumping
    bool jump = false;

    public bool tripleSpeed = false;

    // Update is called once per frame
    void Update()
    {
        switch (tripleSpeed)
        {
            case false:
                runSpeed = 100f;
                break;
            case true:
                runSpeed = 300f;
                break;
        }
        // Uses players input of A and D keys to move character in FixedUpdate
        horizontalMove = Input.GetAxisRaw("p1Horizontal") * runSpeed;

        // Uses players input of SpaceBar to make the character Jump
        if (Input.GetButtonDown("P1Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        // Disables jump so player cannot jump twice
        jump = false;
    }
}
