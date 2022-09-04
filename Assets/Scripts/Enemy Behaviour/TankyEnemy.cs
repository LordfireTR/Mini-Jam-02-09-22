using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankyEnemy : EnemyBehaviour
{
    public override void Begin()
    {
        base.Begin();
        enemyHealth *= 1.5f;
    }
}
