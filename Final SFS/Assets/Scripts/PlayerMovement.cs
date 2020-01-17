using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public float runSpeed = 40f;

    public float acceleration = 1.0f;
    public float maxSpeed = 60.0f;

    private float curSpeed = 0.0f;

    public int extraJumps;

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        SpeedTextScript.speed = (int)Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            FindObjectOfType<AudioManager2>().Play("PlayerJump");
            extraJumps--;
        }


        /*
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }*/
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
