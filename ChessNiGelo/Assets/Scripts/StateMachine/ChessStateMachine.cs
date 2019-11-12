using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessStateMachine : StateMachine
{
    public List<IState> StatesList;
    public IState CurrentState;

    [SerializeField]
    List<IManager> Managers;

    public void Start()
    {
        StatesList = new List<IState>();

        StatesList.Add(new BOARD_INIT_STATE(Managers[(int)ManagerType.TILEMANAGER],this));
<<<<<<< HEAD
<<<<<<< HEAD
        StatesList.Add(new BOARD_SETUP_STATE(Managers[(int)ManagerType.TILEMANAGER],Managers[(int)ManagerType.CHESSMANAGER],this));
        StatesList.Add(new WHITE_PIECE_IDLE_STATE(Managers[(int)ManagerType.TILEMANAGER],Managers[(int)ManagerType.CHESSMANAGER], this));
=======
        StatesList.Add(new BOARD_SETUP_STATE(Managers[(int)ManagerType.CHESSMANAGER],this));

>>>>>>> Inclded instantiation of Pawns
=======
        StatesList.Add(new BOARD_SETUP_STATE(Managers[(int)ManagerType.TILEMANAGER],Managers[(int)ManagerType.CHESSMANAGER],this));
        StatesList.Add(new WHITE_PIECE_IDLE_STATE(Managers[(int)ManagerType.TILEMANAGER],Managers[(int)ManagerType.CHESSMANAGER], this));
>>>>>>> Included new IDLE state in which the player can now select a spot
        ChangeState(States.BOARD_INITIALIZIATION_STATE);
    }

    public void Update()
    {
        if(CurrentState !=null)
        CurrentState.Run();
    }
    

    public override bool ChangeState(States nextState)
    {
        
        if(nextState != null)
        {
           if(CurrentState != null)
            {
                Debug.Log("Exiting state of" + CurrentState.ToString());
                CurrentState.Exit();
            }
<<<<<<< HEAD
<<<<<<< HEAD
            //Debug.Log("Changing state to" + nextState.ToString());
=======
            Debug.Log("Changing state to" + nextState.ToString());
>>>>>>> Inclded instantiation of Pawns
=======
            //Debug.Log("Changing state to" + nextState.ToString());
>>>>>>> Included new IDLE state in which the player can now select a spot
            CurrentState = StatesList[(int)nextState];
            CurrentState.Init();
            return true;
        }

        return false;
    }

    public override bool IsComplete()
    {
        throw new System.NotImplementedException();
    }


    
}
 