using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChannel : Base
{
    EnemyBehaviour EnemyBehaviour;
    float channelDuration;

    public override void EnterState(EnemyStateManager enemy)
    {
        EnemyBehaviour = enemy.GetComponent<EnemyBehaviour>();
        EnemyBehaviour.DamagedChannel();
        channelDuration = (EnemyBehaviour as MidBossBehaviour).channelDuration;
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        channelDuration -= Time.deltaTime;

        if(channelDuration <= 0)
        {
            enemy.SwitchState(enemy.EnemyCharge);
        }
    }
}
