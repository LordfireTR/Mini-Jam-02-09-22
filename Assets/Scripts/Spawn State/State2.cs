using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State2 : State0
{
    SpawnManager SpawnManager;
    float waitForSeconds;

   public override void EnterState(SpawnStateManager spawnManager)
   {
        SpawnManager = spawnManager.GetComponent<SpawnManager>();
        Debug.Log("state2, " + SpawnManager.bossCount);
        SpawnManager.SpawnEnemy(4, SpawnManager.bossCount);
   }

   public override void UpdateState(SpawnStateManager spawnManager)
   {
        if (spawnManager.transform.childCount == 0)
        {
            spawnManager.SwitchState(spawnManager.State3);
        }
   }
}
