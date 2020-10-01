// Include or Using Area.
// What library or set of code that we want to use.
// Import it here.
using System.Collections; // Contain commonly file type.
using System.Collections.Generic;// Contain commonly file type.
using UnityEngine;// Contain set of Unity command.

// Inherit Thing. Get preset or setting from MonoBehaviour.
public class Script01 : MonoBehaviour
{
    // This event Start() will trigger or work.
    // When this script is put or create in the game.
     void Start()
    {
        // command; ; is end of this command.
        print("olleH"); //For tracking or debugging.
        Debug.Log("HellO");
        print(100); // To print number, we don't have to use" "
        print("100"); //is different.
        print(100 + 50); //Will get 150.
        print("100" + "50"); //Will get 10050.

        // To create a Variable
        // VariableType VariableName = VariableInitialValue
        string sentence1 = "DDDT"; // string is set of character.
        string sentence2 = "Semester 1";
        print(sentence1 + sentence2); // We will get DDDTSemester 1.
        string sentence3 = "2020";
        print(sentence1[3]); // We will get T. Start from 0.

        int myNumber1 = 30; // Number with no decimal point
        int myNumber2 = 5;

        //print(); is Action Command. So it will do something.
        //string sentence1 = "DDDT"; is Variable Declaraton.
        print(myNumber1 + myNumber2); // We will get 35.
        print(myNumber1 - myNumber2); // We will get 25.
        print(myNumber1 * myNumber2); // We will get 150.
        print(myNumber1 / myNumber2); // We will get 6.
        // int / int we will get int 5/3 will get 1.
        print(5 / 3); // We will get 1 instead of 1.333
        float myDecimal1 = 7.5f; //Don't forget f
        float myDecimal2 = 1.5f; // If it doesn't has f, it will be set to double

        print(myDecimal1 + myDecimal2);
        print(myDecimal1 - myDecimal2);
        print(myDecimal1 * myDecimal2);
        print(myDecimal1 / myDecimal2);

        // If one of variables that we want to do math thing is float,
        // We will get float as a result.
        print(myNumber1 / myDecimal2); // Get float result
        print(myNumber1 * myDecimal2); // Get float result

        bool myState1 = true;
        bool myState = false;

        print(myNumber1 > myNumber2); // Is 30 more than 5 or not? True
        print(myNumber1 < myNumber2); // Is 30 less than 5 or not? False
        print(myNumber1 >= myNumber2);// Is 30 more than or equal to 5 True
        print(myNumber1 <= myNumber2);// Is 30 less than or equal to 5 False
        print(myNumber1 == myNumber2);// Is 30 equal to 5 or not? Use ==? False
        print(myNumber1 != myNumber2);// Is 30 not equal to 5 or not? True

        // = use for assign or setup a value to variable.
        // == use for compare 2 values.
        Vector2 vector2_1 = new Vector2(5, 10);
        print(vector2_1); // print the vector.
        print(vector2_1.x); // print only X value of the vector.
        print(vector2_1.y); // print only Y value of the vector.
        // Commonly use it  for Physics 2D system.

        Vector3 vector3__1 = new Vector3(5, 10, 15);
        print(vector3__1); // print the vector.
        print(vector3__1.x); // print only X value of the vector.
        print(vector3__1.y); // print only Y value of the vector.
        print(vector3__1.z); // print only z value of the vector.
        //commonly  use it for many things. Ex - Postion Rotation Scale

        GameObject myObject;
        // we use this for work with other script.
        // For example, PlayerScripts want to do damage to EnemyScripts.
        // So PlayerScript has to reduce Enemy Health inside Enemyscript.

    }
}

