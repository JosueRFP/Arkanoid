using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTijolo : MonoBehaviour
{
    public GameObject[] blocos;
    public int rowCount = 5;
    public int tijolosPorFileira = 7;
    public float horizontalSpacing = 2.0f;
    public float verticalSpacing = 1.5f;
    public Vector2 startPosition = new Vector2(-7f, 0f);

    void Start()
    {
        SpawnRandomRows(rowCount, tijolosPorFileira, startPosition); 


        void SpawnRandomRows(int rowCount, int tijolosPorFileira, Vector2 startPosition)
        {
            for (int row = 0; row < rowCount; row++)
            {
             
                Vector2 rowStartPosition = new Vector2(startPosition.x, startPosition.y - row * verticalSpacing);

              
                SpawnRandomRow(tijolosPorFileira, rowStartPosition);
            }
        }

        void SpawnRandomRow(int tijolosPorFileira, Vector2 startPosition)
        {
            float px = startPosition.x;

            for (int i = 0; i < tijolosPorFileira; i++)
            {
                int random = Random.Range(0, blocos.Length); 
                Vector2 spawnPosition = new Vector2(px, startPosition.y); 
                Instantiate(blocos[random], spawnPosition, Quaternion.identity); 
                px += horizontalSpacing; 
            }
        }
    }
}