using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using Managers_Controllers;

public class GameManager : IManager
{ 

    [SerializeField]
    TileManager t_manager;



    private void Start()
    {
       // t_manager.Init();
    }


    private void Update()
    {
        
    }

    private void HandleInput()
    {

    }


    //TroopManager.TryMoveTroop(TroopID,TileID)

    //If(Tiled.CointainsNothing)
    //{return MoveTroop();}
    //MoveTroop(TroopID,TileID)

    //
=======

public class GameManager : MonoBehaviour
{


    [SerializeField]
    TileManager t_manager;


    private void Start()
    {
        t_manager.Init();
    }

    
<<<<<<< HEAD
>>>>>>> Added initial project
=======

    //TroopManager.MoveTroop(TroopID,TileID)

>>>>>>> Included Instantiation of the board
}
