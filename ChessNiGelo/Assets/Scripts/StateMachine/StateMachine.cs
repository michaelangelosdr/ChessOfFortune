using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{

    public  IState CurrentState;
    public abstract bool ChangeState(States nextState);

    public abstract bool IsComplete();
}
