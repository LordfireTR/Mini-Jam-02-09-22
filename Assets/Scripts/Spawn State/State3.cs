using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State3 : State0
{
    SpawnManager SpawnManager;

    public override void EnterState(SpawnStateManager spawnManager)
    {
        Debug.Log("state3");
        SpawnManager = spawnManager.GetComponent<SpawnManager>();
        SpawnManager.SpawnContinue();
    }

    public override void UpdateState(SpawnStateManager spawnManager)
    {
        SpawnManager.SpawnEnemy();
        SpawnManager.NextStage();
        if (SpawnManager.MidBossStageBool())
        {
            spawnManager.SwitchState(spawnManager.State2);
        }
    }
}
