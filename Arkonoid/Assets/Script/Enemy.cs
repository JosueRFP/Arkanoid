using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public event Action<GameObject> OnDeath;

   
    void Die()
    {
        
        if (OnDeath != null)
        {
            OnDeath(gameObject);
        }

        
        Destroy(gameObject);
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Die();
        }
    }
}