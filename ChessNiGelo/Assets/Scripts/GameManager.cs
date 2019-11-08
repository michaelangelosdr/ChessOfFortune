using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
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
=======
using Managers_Controllers;
>>>>>>> Inclded instantiation of Pawns

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

<<<<<<< HEAD
    
<<<<<<< HEAD
>>>>>>> Added initial project
=======
=======
    private void HandleInput()
    {

    }


    //TroopManager.TryMoveTroop(TroopID,TileID)
>>>>>>> Inclded instantiation of Pawns

    //If(Tiled.CointainsNothing)
    //{return MoveTroop();}
    //MoveTroop(TroopID,TileID)

<<<<<<< HEAD
>>>>>>> Included Instantiation of the board
=======
    //
>>>>>>> Inclded instantiation of Pawns
}
