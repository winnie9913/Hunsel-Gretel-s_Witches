using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject targetToFollow;
    public bool followOnX = true;
    public bool followOnY = true;
    public float offsetPositionX = 0.0f;
    public float offsetPositionY = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targetToFollow != null) // check if we are not forget to set it.
        {
            float nextPositionX = gameObject.transform.position.x; // We attach to camera, so gameObject is Camera.
            float nextPositionY = gameObject.transform.position.y;

            if(followOnX == true)
            {
                nextPositionX = targetToFollow.transform.position.x;
            }
            if (followOnY == true)
            {
                nextPositionY = targetToFollow.transform.position.y;

            }

            gameObject.transform.position = new Vector3(nextPositionX, nextPositionY, -10);
        }
    }
}
