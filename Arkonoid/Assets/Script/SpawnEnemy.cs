using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate;
    float timer;
    public Transform spawnPos;
    public Transform[] spawnPoitns; //Array
    public List<GameObject> enemies; // Lista 

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("Spawn", 0, spawnRate); Nao pode usar coisa de amador

        StartCoroutine(TesTe());

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            // Spawn(Random.Range(1,10));
            Spawn(1);
            timer = 0;
        }
    }
    void Spawn(int qtd)
    {
        for (int i = 0; i < qtd; i++)
        {
            int random = Random.Range(0, spawnPoitns.Length);
            enemies.Add(Instantiate(enemyPrefab, spawnPoitns[random].position, spawnPoitns[random].rotation));
            /*
            if (i == qtd / 2)
            {
                enemies[i].GetComponent<SpriteRenderer>().color = Color.black;
            }
            */
        }

    }
    IEnumerator TesTe()
    {

        for (int i = 0; i < 5; i++)
        {
            print("Foi" + i);
            yield return new WaitForSeconds(2);
        }




    }



}
