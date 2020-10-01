using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSight : MonoBehaviour
{
    GameObject targetPlayerToChase = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D overlapWithObject)
    {
        if(overlapWithObject.gameObject.CompareTag("player") == true)
        {
            targetPlayerToChase = overlapWithObject.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D overlapWithObject)
    {
        if(overlapWithObject.gameObject.CompareTag("Player") == true)
        {
            targetPlayerToChase = null;
        }
    }
}
