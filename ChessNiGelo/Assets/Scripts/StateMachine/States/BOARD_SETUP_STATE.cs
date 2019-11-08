using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers_Controllers;

public class BOARD_SETUP_STATE : IState
{
<<<<<<< HEAD
    TileManager t_manager;

    public BOARD_SETUP_STATE(IManager tilemanager,IManager manager, StateMachine machine): base(manager,machine)
    {
        CurrentManager = manager;
        s_machine = machine;
        t_manager = tilemanager as TileManager;
=======
    public BOARD_SETUP_STATE(IManager manager, StateMachine machine): base(manager,machine)
    {
        CurrentManager = manager;
        s_machine = machine;
        
>>>>>>> Inclded instantiation of Pawns
    }

    public override void Exit()
    {
<<<<<<< HEAD
     
=======
        throw new System.NotImplementedException();
>>>>>>> Inclded instantiation of Pawns
    }

    public override States GetState()
    {
        return States.BOARD_SETUP_STATE;
    }

    public override void Init()
    {
        ChessManager _Manager = CurrentManager as ChessManager;
<<<<<<< HEAD
  
        _Manager.SetallPieces(ChessPlayer.WHITE,t_manager.GameGrid);
        _Manager.SetallPieces(ChessPlayer.BLACK, t_manager.GameGrid);

        s_machine.ChangeState(States.WHITE_PIECE_IDLE_STATE);
=======
        _Manager.SetallPieces();
       
>>>>>>> Inclded instantiation of Pawns
    }

    public override void Run()
    {
<<<<<<< HEAD
       // Debug.Log("I AM IN THIS STATE");
=======
        Debug.Log("I AM IN THIS STATE");
>>>>>>> Inclded instantiation of Pawns
    }
}
