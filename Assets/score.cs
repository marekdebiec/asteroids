using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int overallResult = 0;
    public GameObject score_1;


  

    // Update is called once per frame
    void Update()
    {
        score_1.GetComponent<Text>().text = overallResult.ToString();
    }
    public void Scores ()
    {

        overallResult++;
    }
}
