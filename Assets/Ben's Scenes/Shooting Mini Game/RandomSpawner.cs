using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject en; //enemy prefab

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            int randSpawnPoint = Random.Range(0, spawnPoint.Length);

            Instantiate(en, spawnPoint[randSpawnPoint].position, transform.rotation);
        }
    }
}
