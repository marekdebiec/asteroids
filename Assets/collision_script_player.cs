using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_script_player : MonoBehaviour
{
    public GameObject parent;
    public GameObject button_;
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "enemy")
        {

            // parent.transform.position = new Vector3(0, 0, 0);
            Destroy(gameObject);
            button_.SetActive(true);
            
        }
    }
}
