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
        if (EnemyBehaviour.enemyHealth <= 0)
        {
            EnemyBehaviour.DeathHandler();
        }
    }

    // public override void OnTriggerEnterState(EnemyStateManager enemy, Collider other)
    // {
    //     if(other.CompareTag("Bullet"))
    // }
}
