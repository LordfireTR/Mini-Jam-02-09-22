using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] int xLimit, zSpawn;
    float spawnPeriod, _spawnPeriod;

    void Start()
    {
        spawnPeriod = 2.0f;
        _spawnPeriod = 4.0f;
    }

    void Update()
    {
        if (spawnPeriod <= 0)
        {
            SpawnEnemy();
            spawnPeriod = _spawnPeriod;
        }
        else
        {
            spawnPeriod -= Time.deltaTime;
        }
    }

    void SpawnEnemy()
    {
        int index = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[index], SpawnPos(), Quaternion.Euler(0, 180, 0));
    }

    Vector3 SpawnPos()
    {
        int xSpawn = Random.Range(-xLimit, xLimit + 1);
        Vector3 spawnPos = new Vector3(xSpawn, 1, zSpawn);
        return spawnPos;
    }
}
