using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State1 : State0
{
    SpawnManager SpawnManager;

    public override void EnterState(SpawnStateManager spawnManager)
    {
        Debug.Log("state1");
        SpawnManager = spawnManager.GetComponent<SpawnManager>();
        SpawnManager.SpawnStart();
    }

    public override void UpdateState(SpawnStateManager spawnManager)
    {
        SpawnManager.SpawnEnemy();
        SpawnManager.NextStage();
        if (SpawnManager.MidBossStageBool())
        {
            spawnManager.SwitchState(spawnManager.State2);
        }
        SpawnManager.cheat();
    }
}
