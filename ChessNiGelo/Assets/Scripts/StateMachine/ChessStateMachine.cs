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
        StatesList.Add(new BOARD_SETUP_STATE(Managers[(int)ManagerType.TILEMANAGER],Managers[(int)ManagerType.CHESSMANAGER],this));
        StatesList.Add(new WHITE_PIECE_IDLE_STATE(Managers[(int)ManagerType.TILEMANAGER],Managers[(int)ManagerType.CHESSMANAGER], this));
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
            //Debug.Log("Changing state to" + nextState.ToString());
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
 