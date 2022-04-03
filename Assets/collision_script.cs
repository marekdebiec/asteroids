using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision_script : MonoBehaviour
{
    public SpriteRenderer rend;
    public CircleCollider2D coll;
    public GameObject score_script;
    public float speed ;
    public Vector3 vector_1;
   // public Vector3 startPosition;
    public Transform other;

    void Start ()
    {
        other = GameObject.FindWithTag("Player").transform;
      //  float a = transform.position.x;
       // float b = Vector3.Distance(other.position, transform.position);
       // startPosition = new Vector3(a, startPosition.y + b, 0);
        score_script = GameObject.Find("333");
        speed = Random.Range(0.01f, 0.02f);
        vector_1 = new Vector3(Random.Range(-180.0f, 180.0f), Random.Range(-180.0f, 180.0f), 0);

    } 
    void Update ()
    {
        // Move the object
        transform.Translate(vector_1 * speed * Time.deltaTime);
    }
   
    // void OnCollisionEnter2D(Collision2D collision)
    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.tag == "bullet") {
            score_script.GetComponent<score>().Scores();

            StartCoroutine(coroutineA());

        }
        if (col.tag == "enemy")
        {         
            StartCoroutine(coroutineA());
        }
       
    }
    IEnumerator coroutineA()
    {
      //  GameObject[] gos;
      //  gos = GameObject.FindGameObjectsWithTag("first");
       // int number = Random.Range(0, gos.Length);
        coll = GetComponent<CircleCollider2D>();        
        rend = GetComponent<SpriteRenderer>();
        coll.enabled = false;
        rend.enabled = false;
        yield return new WaitForSeconds(1);
        float b = Vector3.Distance(other.position, transform.position);
        transform.Translate(0, b, 0);
        // transform.position = gos[number].transform.position;
        // transform.position = startPosition;
        rend.enabled = true;
        coll.enabled = true;


    }
  
}
