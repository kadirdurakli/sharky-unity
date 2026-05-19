using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockspawner : MonoBehaviour
{
    public Sharky SharkScript;
    public GameObject Rock;
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    
    void Update()
    {
        
    }

    public IEnumerator SpawnObject()
    {
        while(!SharkScript.isDead)
        {
            Instantiate(Rock, new Vector3(9.73f, Random.Range(-0.97f, -4.32f),0) , Quaternion.identity);
            yield return new WaitForSeconds(4f);
        }
            
    }
}
