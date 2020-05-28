using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers_Controllers;

public class BOARD_SETUP_STATE : IState
{
    TileManager t_manager;

    public BOARD_SETUP_STATE(IManager tilemanager,IManager manager, StateMachine machine): base(manager,machine)
    {
        CurrentManager = manager;
        s_machine = machine;
        t_manager = tilemanager as TileManager;
    }

    public override void Exit()
    {
     
    }

    public override States GetState()
    {
        return States.BOARD_SETUP_STATE;
    }

    public override void Init()
    {
        ChessManager _Manager = CurrentManager as ChessManager;
  
        _Manager.SetallPieces(ChessPlayer.WHITE,t_manager.GameGrid);
        _Manager.SetallPieces(ChessPlayer.BLACK, t_manager.GameGrid);

        s_machine.ChangeState(States.WHITE_PIECE_IDLE_STATE);
    }

    public override void Run()
    {
       // Debug.Log("I AM IN THIS STATE");
    }
}
