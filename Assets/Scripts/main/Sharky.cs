using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharky : MonoBehaviour
{
    public bool isDead;
    public Rigidbody2D rb2D;
    public GameObject DeadScreen;
    public GameManager managerGame;

    void Start()
    {
        Time.timeScale = 1;
    }

    
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Kaya")
        {
             isDead = true;
             Time.timeScale = 0;           
             Debug.Log("temas");
             DeadScreen.SetActive(true);
            
        }
        if(collision.gameObject.tag == "Big")
        {
            isDead = true;
            Time.timeScale = 0;
            Debug.Log("temas");
            DeadScreen.SetActive(true);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Balık")
        {
            managerGame.UpdateScore();
        }
        if(collider.gameObject.tag == "altınbalık")
        {
            managerGame.UpdateScoreaLot();           
        }
    }
        
    

        
    
}
