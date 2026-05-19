using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb;
    public float moveSpeed;
    public int score;
    public Text ScoreText;
    void Start()
    {
        score = 0;
    }

    

    void Update()
    {
        
    }
    public void UpdateScore()
    {
        score ++;
        ScoreText.text = score.ToString();
    }
    public void UpdateScoreaLot() 
    {
        score += 99999999;
        ScoreText.text = score.ToString();
    }
    public void MoveUp()
    {
        rb.linearVelocity = Vector2.up * moveSpeed;
    }
    public void MoveDown()
    {
        rb.linearVelocity = Vector2.down * moveSpeed;
    }
    public void StopMoving()
    {
        rb.linearVelocity = Vector2.zero;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

}
