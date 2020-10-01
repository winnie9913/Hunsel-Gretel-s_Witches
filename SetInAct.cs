using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInAct : MonoBehaviour
{
    public GameObject Bread;

    int DoughTotalCount;
    int DoughCollected = 0;

    void Awake()
    {
        // Disable your KeyGameObject
        Bread.SetActive(false);

        // Get how many coins on scene
        DoughTotalCount = GameObject.FindGameObjectsWithTag("Dough").Length;
    }

    // Call this method from CoinScript each time you collect coin
    public void DoughCollect()
    {
        DoughCollected++;

        // If you collected all coins - show KeyGameObject
        if (DoughCollected == DoughTotalCount)
           Bread.SetActive(true);
    }
}


