using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers_Controllers;

public class PawnToken : ChessToken
{

<<<<<<< HEAD
    
=======
    [SerializeField]
    Renderer renderer; 
    public void Initialize(ChessPlayer player)
    {
        this.Type = ChessTokenType.PAWN;
        
        if(player == ChessPlayer.WHITE)
        {
            renderer.material.color = Color.white;
        }
        else if(player==ChessPlayer.BLACK)
        {
            renderer.material.color = Color.black;
        }
    }
>>>>>>> Inclded instantiation of Pawns

    public override void Move()
    {
        //Add move command here
    }
  
}
