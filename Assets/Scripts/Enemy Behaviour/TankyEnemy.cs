using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankyEnemy : EnemyBehaviour
{
    public override void Begin()
    {
        base.Begin();
        enemyMaxHealth *= 1.5f;
        enemyHealth = enemyMaxHealth;
    }
}
