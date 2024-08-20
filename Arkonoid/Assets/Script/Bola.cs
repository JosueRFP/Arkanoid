using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    void LaunchBall()
    {
       
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), 1f).normalized;
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        Vector2 reflectDir = Vector2.Reflect(rb.velocity.normalized, collision.contacts[0].normal);
        rb.velocity = reflectDir * speed;
    }
}
