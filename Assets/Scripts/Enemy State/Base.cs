using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Base 
{
    public abstract void EnterState(EnemyStateManager enemy);

    public abstract void UpdateState(EnemyStateManager enemy);

    //public abstract void OnTriggerEnterState(EnemyStateManager enemy, Collider other);
}
