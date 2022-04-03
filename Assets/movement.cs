using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
     
    public float speed = 5f;
   

    // Update is called once per frame
    void Update()
    {
     
        float translation = Input.GetAxis("Vertical") * speed;
      

        // Move translation 
        
        transform.Translate(0, Mathf.Abs(translation), 0);
        
    }
}
