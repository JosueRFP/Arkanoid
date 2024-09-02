using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTijolo : MonoBehaviour
{
    public GameObject tijoloPrefab;
    public GameObject[] blocos;
    public int rowCount = 5;
    public int enemiesPerRow = 6;
    public float horizontalSpacing = 2.0f;
    public float verticalSpacing = 2.0f;
    public Vector2 startPosition = new Vector2(-5f, 0f);

    void Start()
    {
        SpawnRows(rowCount, enemiesPerRow, startPosition);
        spawnss(4);
    }

    void SpawnRows(int rowCount, int enemiesPerRow, Vector2 startPosition)
    {
        for (int row = 0; row < rowCount; row++)
        {
            Vector2 rowStartPosition = new Vector2(startPosition.x, startPosition.y - row * verticalSpacing);
            SpawnRow(enemiesPerRow, rowStartPosition);
        }
    }

    void SpawnRow(int enemyCount, Vector2 startPosition)
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Vector2 spawnPosition = new Vector2(startPosition.x + i * horizontalSpacing, startPosition.y);
            Instantiate(tijoloPrefab, spawnPosition, Quaternion.identity);
        }
    }

    void spawnss(int qtd)
    {
        int random = 0;
        float px = -12f;
        float py = 6.4f;

        for (int i = 0; i < 4; i++)
        {
            px = -12f;
            for (int j = 0; j < 13; j++)
            {
                random = Random.Range(0, blocos.Length); 
                Vector2 pos = new Vector2(px, py);
                Instantiate(blocos[random], pos, Quaternion.identity); 
                px += 2;
            }
            py -= 0.5f;
        }
    }
}