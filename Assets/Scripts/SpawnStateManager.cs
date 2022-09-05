using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStateManager : MonoBehaviour
{
    public State1 State1 = new State1();
    public State2 State2 = new State2();
    public State3 State3 = new State3();

    public State0 currentState;

    public void Start()
    {
        currentState = State1;
        currentState.EnterState(this);
    }
    
    public void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(State0 newState)
    {
        currentState = newState;
        currentState.EnterState(this);
    }
}
