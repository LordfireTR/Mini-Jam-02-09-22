using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State1 : State0
{
    SpawnManager SpawnManager;
    float bossStageCooldown;

    public override void EnterState(SpawnStateManager spawnManager)
    {
        Debug.Log("state1");
        bossStageCooldown = 4.0f;
        SpawnManager = spawnManager.GetComponent<SpawnManager>();
        SpawnManager.SpawnStart();
    }

    public override void UpdateState(SpawnStateManager spawnManager)
    {
        if (SpawnManager.MidBossStageBool())
        {
            if (bossStageCooldown <= 0)
            {
                SpawnManager.bossCount++;
                spawnManager.SwitchState(spawnManager.State2);
            }
            bossStageCooldown -= Time.deltaTime;
        }
        else
        {
            SpawnManager.SpawnEnemy();
            SpawnManager.NextStage();
        }
        SpawnManager.cheat();
    }
}
