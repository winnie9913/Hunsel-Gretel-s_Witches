using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsChaMovement : MonoBehaviour
{
    public Rigidbody2D rigid2D; //Have to get Rigidbody2D component to use ohysics command in this scrip
    // Start is called before the first frame update

    public Animator animController;

    bool canPlayerJump = true;
    int playerJumpstep = 0;
    public int maximumJumpStep = 2;
    public int attackpower = 1;
    public GameObject attackAreaObject;

    public AttackArea attackArea;

    void Start()
    {
        attackAreaObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       // Forcesystem_Movement();
       Velocity_Movement();
      //  Active_jump();
       // Active_Attacking();
    }
    void Forcesystem_Movement()
    {
    
        if (Input.GetKey(KeyCode.A) == true)
        {
            rigid2D.AddForce(new Vector2(-5.0f, 0.0f)); //Add Force -10 on X Axis and 0 on Y Axis.
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            rigid2D.AddForce(new Vector2(5.0f, 0.0f)); // Add Force 10 on X Axis and 0 on Y Axis
        }
    }
    void Velocity_Movement()
    {
        if (Input.GetKey(KeyCode.A) == true)
        {
            Vector2 currentSpeed = rigid2D.velocity;
            rigid2D.velocity = new Vector2(-5.0f, currentSpeed.y);
            animController.SetBool("IsMoving", true);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            Vector2 currentSpeed = rigid2D.velocity;
            rigid2D.velocity = new Vector2(5.0f, currentSpeed.y);
            animController.SetBool("IsMoving", true);
        }
        if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
        {
            Vector2 currentspeed = rigid2D.velocity;
            rigid2D.velocity = new Vector2(0.0f, currentspeed.y);

            animController.SetBool("IsMoving", false);
        }
    }
   // void Active_jump()
   // {
      //  if(Input.GetKeyDown(KeyCode.Space)== true && playerJumpstep < maximumJumpStep )
       // {
         //   Vector2 currentVelocity = rigid2D.velocity;
         //   rigid2D.velocity = new Vector2(currentVelocity.x, 0);
         //   rigid2D.AddForce(new Vector2(0, 300.0f));
           // playerJumpstep += 1; // Add playerJumpstep by 1 everytime player jump.
       // }
       // if (Input.GetKeyDown(KeyCode.Space) == true && playerJumpstep < maximumJumpStep)
       // {

       // }
  //  }

   // void Active_Attacking()
    //{
      //  if(Input.GetButtonDown("Fire1") == true ) //Fire1 Lmouse, Fire2 Rmouse, Fire3 Midmouse 
       // {
        //    attackArea.nextAttackPower = attackpower;
         //   animController.SetTrigger("Attacking");

       // }
   // }


    private void OnCollisionEnter2D(Collision2D hitWithObject)
    {
        // hitWithObject is the object that this object collide or overlap with.
        print("Player START to collide with :" + hitWithObject.gameObject.name);  

        // Check if this object collide with an object using Gamelevel_Ground Tag or not.
        if(hitWithObject.gameObject.CompareTag("GameLevel_Ground") == true )
        {
            print("Player is collide with Level Ground");

            //canPlayerJump = true; // Let player can jump again if player is back on the ground
            playerJumpstep = 0; //Set the playerjump back to 0 when landing on the ground

        }
    }

    private void OnCollisionStay2D(Collision2D hitWithObject)
    {

    }

    private void OnCollisionExit2D(Collision2D hitWithObject)
    {
        //print("Player STOP to collide with :" + hitWithObject.gameObject.name);

        if (hitWithObject.gameObject.CompareTag("GameLevel_Ground") == true)
        {

            canPlayerJump = false; //set canPalyerjump to false when this object leave the ground
        }
        else
        {
            canPlayerJump = true;
        }
    }

    public void Active_AttackAreaCollision()
    {
        attackAreaObject.SetActive(true);
      
    }

    public void Deactive_AttackAreaCollision()
    {
        attackAreaObject.SetActive(false);

    }
}
