using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    public EnemySimple EnemySimple = new EnemySimple();
    public EnemyChannel EnemyChannel = new EnemyChannel();
    public EnemyCharge EnemyCharge = new EnemyCharge();
    
    
    public Base currentState;
    void Start()
    {
        currentState = EnemySimple;
        currentState.EnterState(this);
    }
    
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(Base state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
