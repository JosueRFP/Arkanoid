using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float maxX = 8f;
    public int score = 0; 
    public int scoreToWin = 500; 
    public Text scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        Vector2 newPosition = transform.position + Vector3.right * input * speed * Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, -maxX, maxX);

        transform.position = newPosition;

        CheckScore(); 
    }

   
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText(); 
    }

   
    void CheckScore()
    {
        if (score >= scoreToWin)
        {
            
            SceneManager.LoadScene("Vitoria");
        }
    }

   
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}