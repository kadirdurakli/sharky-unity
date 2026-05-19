using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigsharkspawner : MonoBehaviour
{
    public Sharky SharkScript;
    public GameObject BigShark;
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
            Instantiate(BigShark, new Vector3(13.41f, Random.Range(-1.25f, -3.73f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3f);

        }

    }
}
