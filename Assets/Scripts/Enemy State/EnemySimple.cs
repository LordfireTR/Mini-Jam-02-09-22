using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySimple : Base
{
    EnemyBehaviour EnemyBehaviour;
    public override void EnterState(EnemyStateManager enemy)
    {
        EnemyBehaviour = enemy.GetComponent<EnemyBehaviour>();
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        EnemyBehaviour.Movement();
    }
}
