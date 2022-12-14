using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySimple : Base
{
    EnemyBehaviour EnemyBehaviour;
    
    public override void EnterState(EnemyStateManager enemy)
    {
        EnemyBehaviour = enemy.GetComponent<EnemyBehaviour>();
        EnemyBehaviour.Begin();
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        EnemyBehaviour.Movement();
        if (EnemyBehaviour.isBoss && EnemyBehaviour.enemyHealth <= EnemyBehaviour.enemyMaxHealth / 2)
        {
            enemy.SwitchState(enemy.EnemyChannel);
        }

        if (EnemyBehaviour.enemyHealth <= 0)
        {
            EnemyBehaviour.DeathHandler();
        }
        
    }
}
