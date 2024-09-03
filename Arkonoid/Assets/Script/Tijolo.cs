using System;
using System.Collections;

using UnityEngine;

public class Tijolo : MonoBehaviour
{
    private SpawnTijolo spawner;

    public GameObject[] powerUps; 
    public float dropChance = 0.4f; 
    private bool canDrop = true;

    public void SetSpawner(SpawnTijolo spawner)
    {
        this.spawner = spawner;
    }

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

        if (spawner != null)
        {
            spawner.RespawnTijolo(gameObject);
        }

        if (canDrop)
        {
            TryDropPowerUp();
        }

        Destroy(gameObject);
    }

    private void TryDropPowerUp()
    {
        if (UnityEngine.Random.value <= dropChance) 
        {
            int randomIndex = UnityEngine.Random.Range(0, powerUps.Length); 
            Instantiate(powerUps[randomIndex], transform.position, Quaternion.identity);
            StartCoroutine(ResetDropCooldown());
        }
    }

    private IEnumerator ResetDropCooldown()
    {
        canDrop = false;
        yield return new WaitForSeconds(10f);
        canDrop = true;
    }
}