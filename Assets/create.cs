using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    public Transform prefab;
    public GameObject[] rzedy;
    public GameObject[] kolumny;

  //  public Vector3 position_;

    // Start is called before the first frame update
    
    void Start()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        for (int i = 0; i < rzedy.Length; i++)
        {
          //  Instantiate(prefab, transform.position, transform.rotation);

        }
       // position_ = transform.position;
    }

   
}
