using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed; 

    // Update is called once per frame
    void Update()
    {
        // Move translation 
         transform.Translate(0, speed * Time.deltaTime, 0);
       

        // Kills the game object in ... seconds after loading the object
        Destroy(gameObject, 3);
       
    }
}
