using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate;
    private float timer;
    public Transform[] spawnPoints; // Array
    public List<GameObject> enemies; // Lista 

    void Start()
    {
       
        Spawn(1);
    }

    void Update()
    {
        timer += Time.deltaTime;

        
        if (timer >= spawnRate)
        {
            Spawn(1);
            timer = 0;
        }

        
        enemies.RemoveAll(item => item == null);
    }

    void Spawn(int qtd)
    {
        for (int i = 0; i < qtd; i++)
        {
            int random = Random.Range(0, spawnPoints.Length);
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPoints[random].position, spawnPoints[random].rotation);
            enemies.Add(newEnemy);

            
            newEnemy.GetComponent<Enemy>().OnDeath += HandleEnemyDeath;
        }
    }

    
    void HandleEnemyDeath(GameObject enemy)
    {
        enemies.Remove(enemy); 
        Spawn(1); 
    }
}
