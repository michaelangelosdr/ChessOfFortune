using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IState 
{
    public IManager CurrentManager;

    public StateMachine s_machine;

    protected IState(IManager manager, StateMachine machine) { s_machine = machine; CurrentManager = manager; }

    public abstract States GetState();

    public abstract void Init();

    public abstract void Run();

    public abstract void Exit();

}
