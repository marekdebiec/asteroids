using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid_manager : MonoBehaviour
{
    public float x_Start, y_Start;
    public int rowLength , columnLength;
    public float x_Space, y_Space;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < columnLength * rowLength; i++)
        {
            // Instantiate(prefab, new Vector3(x_Start + (x_Space *(i % columnLength)), y_Start + (-y_Space * ( i / rowLength))),Quaternion.identity);
            GameObject somethingNew = Instantiate(prefab, new Vector3(x_Start + (x_Space * (i % columnLength)), y_Start + (-y_Space * (i / rowLength))), Quaternion.identity);
            somethingNew.transform.parent = gameObject.transform;
            somethingNew.tag = "first";
        }
    }

  
}
