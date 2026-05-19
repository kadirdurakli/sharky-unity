using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigsharkmove : MonoBehaviour
{
    
    public float speed;
    void Start()
    {
        Destroy(gameObject, 5.5f);
    }

    
    void Update()
    {
        transform.position += Vector3.left * speed *Time.deltaTime;
    }
}
