using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    bool statement = true;
    public Transform prefab;
    public GameObject ship;

    // Update is called once per frame
    void Update()
    {
        //Start the coroutine  named ExampleCoroutine.
        if (statement) {
            StartCoroutine(ExampleCoroutine());
        }
    }
    IEnumerator ExampleCoroutine()
    {

            statement = false;    

            Instantiate(prefab, ship.transform.position, ship.transform.rotation);

            //yield on a new YieldInstruction that waits for ... seconds.
            yield return new WaitForSeconds(.5f);
            statement = true;

       

    }
}
