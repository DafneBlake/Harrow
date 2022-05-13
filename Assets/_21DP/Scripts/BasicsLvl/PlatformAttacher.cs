using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttacher : MonoBehaviour
{
    public bool onPlatform = false;
    public Rigidbody rb;
    public Rigidbody platformRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (onPlatform)
        {
            rb.velocity += new Vector3(platformRigidbody.velocity.x, 0, platformRigidbody.velocity.z);
        }
    }
}
