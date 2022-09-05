using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharge : Base
{
    EnemyBehaviour EnemyBehaviour;

    public override void EnterState(EnemyStateManager enemy)
    {
        EnemyBehaviour = enemy.GetComponent<EnemyBehaviour>();
        (EnemyBehaviour as MidBossBehaviour).DamagedCharge();
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        EnemyBehaviour.Movement();

        if (EnemyBehaviour.enemyHealth <= 0)
        {
            EnemyBehaviour.DeathHandler();
        }
    }
}
