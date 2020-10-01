using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBehavior : MonoBehaviour
{
    public int HP = 10; // This is the slime HP
    // Note If your game has Regeneration System, HP should be float.

    public Rigidbody2D slimeRigid;

    bool onMoveLeft = true;
    float patrolDistance = 2.0f;
    Vector3 startpatrolPosition;
    public SlimeSight sightBehavior;


    // Start is called before the first frame update
    void Start()
    {
        startpatrolPosition = gameObject.transform.position; //Get it position when the game is start. the orginal position of the slime
    }

    // Update is called once per frame
    void Update()
    {
        if (onMoveLeft == true) 
        {
         Vector2 currentVelocity = slimeRigid.velocity;
         slimeRigid.velocity = new Vector2(-100.0f * Time.deltaTime, currentVelocity.y);
        if( Mathf.Abs (gameObject.transform.position.x - startpatrolPosition.x) >= patrolDistance)
        {
            onMoveLeft = false;
            slimeRigid.velocity = new Vector2(0.0f, currentVelocity.y);
        }

        }
        else if (onMoveLeft == false)
        {
            Vector2 currentVelocity = slimeRigid.velocity;
            slimeRigid.velocity = new Vector2(300.0f * Time.deltaTime, currentVelocity.y);
            if (gameObject.transform.position.x >= startpatrolPosition.x)
            {
                onMoveLeft = true;
                slimeRigid.velocity = new Vector2(0.0f, currentVelocity.y);
            }
        }
    }
    

    public void Update_HP(int amountToUpdate)
    {
        HP += amountToUpdate; // Update HP by amountToUpdate value, Set -X to deal DMG
        print("Slime HP is " + HP);

        if(HP <= 0)
        {
            Destroy(gameObject);

        }
        else
        {
            if(amountToUpdate < 0) //That means it is the dmg
            {
                //Knock it back a little bit
                slimeRigid.AddForce(new Vector2(5000, 5000) );
            }
        }
    }
}
