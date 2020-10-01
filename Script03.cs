using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Repeatition
        //Reprat doing something
        //For Loop and While Loop
        //For Loop use with some work that we know how many time it will be repaeted
        //While Loop use with some work that we are now quite sure how many time it will be repeated
        
        //For Loop
        //For(Initialize, RepeatCondition, Increment)
        //Start from round is 0
        //Repeat if round still less than 10
        //Everytime it finish its work inside{}, round add by 1
        for(int round = 0; round < 10; round+=1)
        {
            //When String + by other variable type.
            //It will change that variable to String then Add
            print("Round : " + round);

        }
        
        //Start from 10, Keep repeat if it still more than 0.
        //And subtract everytime it finish one loop
        for(int count = 10; count >= 0; count -=1)
        {
            print("Countdown : " + count);// 10 9 8 7 6 5 4 3 2 1 0
        }
        //For example usage in game, Burst Fire Mode.
        //Normal assault rifle , spawn only one bullet or fire only once
        //But burst fire assault rifle, we use for loop to spawn 3 bullets instead.

        //While Loop
        //while( Condition_Statement) { Put our code here.}
        //Repeat until the condition is not correct.
        //Becareful to use while loop
        //Because it can create infinite loop and make your game stop.
        int index = 0;
        while(index < 10)
        {
            print("index : " + index);
            index += 1;
        }

        //For Loop and whike Loop will do their work in 1 frame
    }


}
