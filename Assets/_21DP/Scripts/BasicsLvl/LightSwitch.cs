using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<Light>().enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            GetComponent<Light>().enabled = false;
        }
    }
}
