﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentInterObj  = null;

    private void Update()
    {
        if (Input.GetButtonDown ("Fire1") && currentInterObj )
        {
            currentInterObj.SendMessage("DoInteraction");
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Dough"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Dough"))
        {
            if (other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            

        }
    }
}
