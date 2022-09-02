using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    public EnemySimple EnemySimple = new EnemySimple();
    //public EnemyIdle IdleState = new EnemyIdle();
    
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

    // void OnTriggerEnter(Collider other)
    // {

    // }

    public void SwitchState(Base state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
