using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    

    // Update is called once per frame
    void Update()
    {
        float rotation = -Input.GetAxis("Horizontal") * rotationSpeed;
        // Rotate around our y-axis
        transform.Rotate(0, 0, rotation);
    }
}
