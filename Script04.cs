using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script04 : MonoBehaviour
{
    //Event Function - The function that call itself when the condition is correct
    //Start will trigger and do its work when this object created in the game
    //When we want to use event Function, We have to write it correctly
    void Start()
    {
        MyFunction_01(); // Call MyFunction_01() to do its work.
        MyFunction_02("Real"); // This kind of Function is reusable
        MyFunction_02("DDDT"); // Can do a lot of thing in just only one Function
        MyFunction_02("Pre-Course");


        MyFunction_03(6, 3, "p"); // make it more useful
        MyFunction_03(6, 3, "s");
        MyFunction_03(6, 3, "m");
        MyFunction_03(6, 3, "d");

        bool examState = Is_PassTheExam(65);

        if(examState == true)
        {
            print("I pass the exam");
        }
        else
        {
            print("I fail the exam");
        }
    }
    // Event Function-Update() do something every frame.
    // If we play on 60 fps than it will do its work 60 times per second
    void Update()
    {

    }
    //Function, Normal Function, Custom Function.
    //ReturnType FunctionName ( Required Parameter) {Put our code here}
    //Void type. Return nothing back to the one that call it.
    //This kind of Function will not work by itself. We have to call it.
    void MyFunction_01() //Create Voidtype Function with no Required Parameter
    {
        print("Activate MyFunction_01");
    }

    //A function that required Parameter
    //ReturnType FunctionName (RP_Type RP_Name , ...... , .....)
    void MyFunction_02(string sentence)
    {
        print("Parameter value is : " + sentence);
    }

    void MyFunction_03(int num_1, int num_2, string mode)
    {
        if (mode == "p")
        {
            int result = num_1 + num_2;
            print("The Plus result is : " + result);

        }
        else if(mode == "s")
        {
            int result = num_1 - num_2;
            print("The Subtract result is : " + result);
        }
        else if (mode == "m")
        {
            int result = num_1 * num_2;
            print("The Multiply result is : " + result);
        }
        else if (mode == "d")
        {
            int result = num_1 / num_2;
            print("The Divide result is : " + result);
        }
    }

    //Retuurn function, Fruitful Function
    //Return or give a value back to the one that call it.
    bool Is_PassTheExam(int examScore)
    {
        bool returnBool = false; // Initialize ReturnValue to false

        if(examScore >= 60) // Check condition
        {
            returnBool = true; //If it is correct, change ReturnValue to true
        }


        return returnBool; //return the
    }
}
