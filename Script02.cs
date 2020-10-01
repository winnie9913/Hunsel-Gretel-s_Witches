using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script02 : MonoBehaviour
{
    // accessibility Modifier - Public means it can be accesed from anywhere include unity
    // when we create a variable as public.
    //we lose ability to change its value here inside the script.
    //we have to change it in Inspector or by script only.
    public int myScore = 0; //Global Variable - can use everywhere inside of this script.
    void Start()
    {
        //Condition - seperate program workflow.
        //for example - If player press A do this, if player pe\ress B do another thing.

        
        //if (Condition statement) {Put our code here}
        //It will do all code inside if{} if Condition Statement is correct
        //If it is int, anything value except 0 is true, 0 is False.
        //Structure is if(),, else if()..... and else.
        //A statement of if else condition.
        //If-Else will do only the first condition
        if (myScore < 60)
        {
            print("I get grade\"F\".");
        }
        else if(myScore >= 60 && myScore < 70)//&& is and, || is or
        {
            print("I get grade\"D\".");
        } 
        else if(myScore >= 70 && myScore < 80)
        {
            print("I get grade\"C\".");
        }
        else if(myScore >= 70 && myScore < 80)
        { 
            print("I get grade\"B\".");
        } 
        else 
        {
            print("I get grade\"A\".");
        }
        //else //If condition statement in if() is not true do this instead
        //{
        //    print("I passs the exam");
        //}
        if(myScore >=90)
        {
            print("\"A\".");
        }
    }
}
