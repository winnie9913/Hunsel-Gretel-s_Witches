using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public GameObject BreadGameObject;
    public DoughCollect gameManager;
   
    int DoughTotalCount;
    int DoughCollected = 0;

    void Awake()
    {
        // Disable your KeyGameObject
        BreadGameObject.SetActive(false);

        // Get how many coins on scene
        DoughTotalCount = GameObject.FindGameObjectsWithTag("Dough").Length;
    }

    // Call this method from CoinScript each time you collect coin
    public void DoughCollect()
    {
        
        DoughCollected ++;

        // If you collected all coins - show KeyGameObject
        if (DoughCollected == DoughTotalCount)
            BreadGameObject.SetActive(true);
    }
    
}


