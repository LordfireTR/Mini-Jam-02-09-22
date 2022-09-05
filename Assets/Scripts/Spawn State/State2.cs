using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State2 : State0
{
    SpawnManager SpawnManager;
    float waitForSeconds;

   public override void EnterState(SpawnStateManager spawnManager)
   {
        Debug.Log("state2");
        SpawnManager = spawnManager.GetComponent<SpawnManager>();
        waitForSeconds = 3.0f;
   }

   public override void UpdateState(SpawnStateManager spawnManager)
   {
        if (Mathf.Approximately(waitForSeconds, 0))
        {
            for (int i = 0; i < SpawnManager.bossCount; i++)
            {
                SpawnManager.SpawnEnemy(4);
            }
        }
        else
        {
            waitForSeconds -= Time.deltaTime;
        }

        if (waitForSeconds < 0 && spawnManager.transform.childCount == 0)
        {
            spawnManager.SwitchState(spawnManager.State3);
        }
   }
}
