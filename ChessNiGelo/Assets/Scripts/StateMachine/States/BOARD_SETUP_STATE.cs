using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers_Controllers;

public class BOARD_SETUP_STATE : IState
{
<<<<<<< HEAD
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
=======
    TileManager t_manager;

    public BOARD_SETUP_STATE(IManager tilemanager,IManager manager, StateMachine machine): base(manager,machine)
    {
        CurrentManager = manager;
        s_machine = machine;
        t_manager = tilemanager as TileManager;
>>>>>>> Included new IDLE state in which the player can now select a spot
    }

    public override void Exit()
    {
<<<<<<< HEAD
<<<<<<< HEAD
     
=======
        throw new System.NotImplementedException();
>>>>>>> Inclded instantiation of Pawns
=======
     
>>>>>>> Included new IDLE state in which the player can now select a spot
    }

    public override States GetState()
    {
        return States.BOARD_SETUP_STATE;
    }

    public override void Init()
    {
        ChessManager _Manager = CurrentManager as ChessManager;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> Included new IDLE state in which the player can now select a spot
  
        _Manager.SetallPieces(ChessPlayer.WHITE,t_manager.GameGrid);
        _Manager.SetallPieces(ChessPlayer.BLACK, t_manager.GameGrid);

        s_machine.ChangeState(States.WHITE_PIECE_IDLE_STATE);
<<<<<<< HEAD
=======
        _Manager.SetallPieces();
       
>>>>>>> Inclded instantiation of Pawns
=======
>>>>>>> Included new IDLE state in which the player can now select a spot
    }

    public override void Run()
    {
<<<<<<< HEAD
<<<<<<< HEAD
       // Debug.Log("I AM IN THIS STATE");
=======
        Debug.Log("I AM IN THIS STATE");
>>>>>>> Inclded instantiation of Pawns
=======
       // Debug.Log("I AM IN THIS STATE");
>>>>>>> Included new IDLE state in which the player can now select a spot
    }
}
