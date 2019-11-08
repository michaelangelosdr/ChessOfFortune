using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IState 
{
    public IManager CurrentManager;

    public StateMachine s_machine;

<<<<<<< HEAD
    protected IState(IManager manager, StateMachine machine) { s_machine = machine; CurrentManager = manager; }
=======
    protected IState(IManager manager, StateMachine machine) { }
>>>>>>> Inclded instantiation of Pawns

    public abstract States GetState();

    public abstract void Init();

    public abstract void Run();

    public abstract void Exit();

}
