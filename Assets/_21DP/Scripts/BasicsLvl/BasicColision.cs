using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
    }
}
