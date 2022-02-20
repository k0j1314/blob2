using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject en; //enemy prefab
    float spawnTimer = 3f;
    float timer = 0f;

    void Start()
    {
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnTimer)
        {
            Spawner();
            timer = 0f;
        }
    }

    void Spawner()
    {
        int randSpawnPoint = Random.Range(0, spawnPoint.Length);

        Instantiate(en, spawnPoint[randSpawnPoint].position, transform.rotation);
    }
}
