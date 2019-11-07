using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    [SerializeField]
    TileManager t_manager;


    private void Start()
    {
        t_manager.Init();
    }

    

    //TroopManager.MoveTroop(TroopID,TileID)

}
