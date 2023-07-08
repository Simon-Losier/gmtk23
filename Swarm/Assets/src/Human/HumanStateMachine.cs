using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanStateMachine
{
    public HumanState CurrentHumanState { get; set; }

    public void Initialize(HumanState startingState)
    {
        CurrentHumanState = startingState;
        CurrentHumanState.EnterState();
    }

    public void ChangeState(HumanState newState)
    {
        CurrentHumanState.ExitState();
        CurrentHumanState = newState;
        CurrentHumanState.EnterState();
    }
}
