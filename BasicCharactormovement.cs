using UnityEngine;

public class BasicCharactormovement : MonoBehaviour
{
    //Create Transform Type Variable name trans
    //we can get other component in more different way and this is one of it.
    public Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    //That means if our game run in 60fps. it will do Update 60 times.
    void Update()
    {
        //Use Input.Getkey() to check that we hold this button or not.
        if (Input.GetKey(KeyCode.W) == true)
        {
            trans.position += new Vector3(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            //  trans.position += new Vector3(0, -0.07f, 0);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            trans.position += new Vector3(-0.07f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            trans.position += new Vector3(0.07f, 0, 0);
        }
    }


}
