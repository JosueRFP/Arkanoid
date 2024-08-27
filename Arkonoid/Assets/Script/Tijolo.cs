using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tijolo : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            Die();
        }
    }
    private void Die()
    {

        Player player = FindObjectOfType<Player>();
        if (player != null)
        {
            player.AddScore(10);
        }

        Destroy(gameObject);
    }

}