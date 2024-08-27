using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Bola : MonoBehaviour
{
    public float speed;
    private int directionX = 1;
    private int directionY = 1;

    private Rigidbody2D body;
    private GameOver gameManager;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameOver>(); 
    }

    void Update()
    {
        body.velocity = new Vector2(speed * directionX, speed * directionY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            directionY *= -1;
            Destroy(gameObject);
            gameManager.ExibirTelaGameOver(); 
        }

        if (collision.gameObject.CompareTag("Parede"))
        {
            directionX *= -1;
        }

        if (collision.gameObject.CompareTag("Teto"))
        {
            directionY *= -1;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            directionY *= -1;
        }

        if (collision.gameObject.CompareTag("Bloco"))
        {
            directionX *= -1;
            Destroy(collision.gameObject); 
        }
    }
}