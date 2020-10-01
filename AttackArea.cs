using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    [HideInInspector] // Hide the next variable from Inspector. Don't let it change by Inspector.
    public int nextAttackPower = 1; // We have to set it as public because we want PlayerMovement to set it.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D overlapWithObject)
    {
        //print("Attack Area is overlap with : " + overlapWithObject.gameObject.name);
        if(overlapWithObject.gameObject.CompareTag("Slime") == true ) //Check, Do we hit a slime.
        {
            SlimeBehavior slimeComponent = overlapWithObject.gameObject.GetComponent<SlimeBehavior>();

            if(slimeComponent != null) // null = no value or not exist
            {
                slimeComponent.Update_HP(-nextAttackPower); //Use Update 
            }

        }
    }

    private void OnTriggerStay2D(Collider2D overlapWithObject)
    {
        
    }

    private void OnTriggerExit2D(Collider2D overlapWithObject)
    {
        //print("Attack Area is not overlap with  : " + overlapWithObject.gameObject.name);
    }
}
