using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishspawner : MonoBehaviour
{
    public Sharky SharkScript;
    public GameObject Fish;
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
            Instantiate(Fish, new Vector3(9.2482f, Random.Range(-0.8556f, -4.622f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }



}
