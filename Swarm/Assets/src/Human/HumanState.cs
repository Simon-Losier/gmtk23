using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanState
{
    protected HumanStateMachine humanStateMachine;

    public HumanState(HumanStateMachine humanStateMachine)
    {
        this.humanStateMachine = humanStateMachine;
    }
    public virtual void EnterState() { }
    public virtual void ExitState() { }
    public virtual void FrameUpdate() { }
    public virtual void PhysicsUpdate() { }
}
