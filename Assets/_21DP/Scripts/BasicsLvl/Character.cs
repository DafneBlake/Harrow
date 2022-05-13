using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public string myName;
    public string myClass;
    public int level;

    void Start()
    {
        ShowData();
    }

    public void ShowData()
    {
        Debug.Log(myName);
        Debug.Log(myClass);
        Debug.Log(level);
    }
}
