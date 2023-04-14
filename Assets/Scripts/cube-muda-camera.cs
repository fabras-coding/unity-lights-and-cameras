using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Camera[] cameras;

    // Start is called before the first frame update
    void Start()
    {

        cameras[0].enabled = true;
        cameras[1].enabled = false;
        cameras[2].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Keypad1))
		{
            cameras[0].enabled = false;
            cameras[1].enabled = true;
            cameras[2].enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            cameras[0].enabled = false;
            cameras[1].enabled = false;
            cameras[2].enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            cameras[0].enabled = true;
            cameras[1].enabled = false;
            cameras[2].enabled = false; 
        }

    }
}
