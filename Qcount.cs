using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qcount : MonoBehaviour
{
    public int DoughTotalCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        DoughTotalCount = GameObject.FindGameObjectsWithTag("Dough").Length;
        





    }


    // Update is called once per frame
    void Update()
    {
        DoughTotalCount = GameObject.FindGameObjectsWithTag("Dough").Length;
        if (DoughTotalCount >0 )
        {
            print ("Dough Left = " + DoughTotalCount);
        
        }
        else 
        {
            print("Completed");
        }
    }
}
