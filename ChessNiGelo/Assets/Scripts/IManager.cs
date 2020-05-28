using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IManager : MonoBehaviour
{
    public ManagerType type;
}

public enum ManagerType
{
    TILEMANAGER = 0,
    CHESSMANAGER = 1,
    GAMEMANAGER =2
}
