using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] int xLimit, zSpawn;
    float spawnPeriod, _spawnPeriod, stagePeriod, _stagePeriod = 20.0f;
    int stageNum, enemyTypes;
    public int bossCount;

    public void SpawnStart()
    {
        spawnPeriod = 2.0f;
        _spawnPeriod = 4.0f;
        stageNum = 0;
        bossCount = 0;
    }

    public void SpawnContinue()
    {
        spawnPeriod = _spawnPeriod;
        stageNum++;
    }

    public void SpawnEnemy()
    {
        if (spawnPeriod <= 0)
        {
            int index = Random.Range(0, enemyTypes);
            //Debug.Log(stageNum + " " + enemyTypes + " " + index);
    
            Instantiate(enemyPrefabs[index], SpawnPos(), Quaternion.Euler(0, 180, 0), gameObject.transform);
            spawnPeriod = _spawnPeriod;
        }
        else
        {
            spawnPeriod -= Time.deltaTime;
        }
    }

    public void SpawnEnemy(int index)
    {
        Instantiate(enemyPrefabs[index], SpawnPos(), Quaternion.Euler(0, 180, 0), gameObject.transform);
        spawnPeriod = 2*_spawnPeriod;
    }

    Vector3 SpawnPos()
    {
        int xSpawn = Random.Range(-xLimit, xLimit + 1);
        Vector3 spawnPos = new Vector3(xSpawn, 1, zSpawn);
        return spawnPos;
    }

    bool NextStageBool()
    {
        if (stagePeriod >= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void NextStage()
    {
        if (!NextStageBool())
        {
            stagePeriod -= Time.deltaTime;
        }
        else
        {
            _spawnPeriod *= 0.8f;
            stagePeriod = _stagePeriod;
            stageNum++;
        }

        if (stageNum < 3)
        {
            enemyTypes = 1;
        }
        else if (stageNum == 3)
        {
            enemyTypes = 2;
        }
        else if (stageNum == 4)
        {
            enemyTypes = 3;
        }
        else if (stageNum > 5 && stageNum < 8)
        {
            enemyTypes = 4;
        }
        else
        {
            enemyTypes = 5;
        }
    }

    public bool MidBossStageBool()
    {
        if (stageNum != 0 && stageNum % 5 == 0)
        {
            bossCount++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void cheat()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            stageNum = 5;
        }
    }
}
