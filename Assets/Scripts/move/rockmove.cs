using System.Collections.Generic;
using UnityEngine;

public class rockmove : MonoBehaviour
{
    public static float speed = 5f; // Statik değişken olarak tanımlandı
    
    public static bool flag = false;
    void Start()
    {
        Destroy(gameObject, 5.5f);
        InvokeRepeating("ChangeSpeed", 0, 1f);
    }

    void ChangeSpeed()
    {
        if (flag == false && speed < 10f) {
             speed += Random.Range(0.1f, 0.5f);
             if (speed >= 10f) {
                 flag = true;
             }
        }

        else if (flag == true && speed > 5f) {
             speed -= Random.Range(0.1f, 0.5f);
             if (speed <= 5f) {
                 flag = false;
             }
        }
    }
    
    void Update()
    {
        Debug.Log("Current Speed: " + speed);
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
