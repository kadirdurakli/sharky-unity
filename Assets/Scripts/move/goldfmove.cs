using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldfmove : MonoBehaviour
{
    public float speed;
    void Start()
    {
        Destroy(gameObject, 5.5f);
    }

    
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {   
        if(collider.gameObject.tag == "anabalık")
        {
            Destroy(gameObject);
            speed += 0.6f;
        }
    }    
}
