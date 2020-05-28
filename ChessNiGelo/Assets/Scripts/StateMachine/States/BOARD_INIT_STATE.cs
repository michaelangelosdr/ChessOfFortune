using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers_Controllers;

public class BOARD_INIT_STATE : IState
{
    public BOARD_INIT_STATE(IManager manager, StateMachine machine): base(manager,machine)
    {
        s_machine = machine;
        CurrentManager = manager;
    }

    public override States GetState()
    {
        return States.BOARD_INITIALIZIATION_STATE;
    }

    public override void Init()
    {
        TileManager _manager = CurrentManager as TileManager;
        _manager.Init();

        s_machine.ChangeState(States.BOARD_SETUP_STATE);
    }

    public override void Run()
    {
        Debug.Log("HEHE");
    }

    public override void Exit()
    {
        
    }

}
