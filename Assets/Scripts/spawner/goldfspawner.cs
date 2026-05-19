using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldfspawner : MonoBehaviour
{
    public GameObject GoldFish;
    public Sharky SharkScript;
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
            Instantiate(GoldFish, new Vector3(10.4721f, Random.Range(-0.8f, -4.572f),0) , Quaternion.identity);
            yield return new WaitForSeconds(6f);
        }
    }
}
