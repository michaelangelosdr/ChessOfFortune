using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
using Managers_Controllers;

public class ChessToken : BoardToken, IMove
{
    public ChessTokenType Type;

    [SerializeField]
    List<Renderer> renderers;
    public void Initialize(ChessPlayer player)
    {
        this.Type = ChessTokenType.HORSE;

        if (player == ChessPlayer.WHITE)
        {
            foreach (Renderer s in renderers)
            {
                s.material.color = Color.white;
            }

        }
        else if (player == ChessPlayer.BLACK)
        {
            foreach (Renderer s in renderers)
            {
                s.material.color = Color.red;
            }
        }
    }
    public virtual void Move()
    {
        Debug.LogError("MOVE NOT IMPLEMENTED");
    }

    
=======
=======
using Managers_Controllers;
>>>>>>> Included new IDLE state in which the player can now select a spot

public class ChessToken : BoardToken, IMove
{
    public ChessTokenType Type;

    [SerializeField]
    List<Renderer> renderers;
    public void Initialize(ChessPlayer player)
    {
        this.Type = ChessTokenType.HORSE;

        if (player == ChessPlayer.WHITE)
        {
            foreach (Renderer s in renderers)
            {
                s.material.color = Color.white;
            }

        }
        else if (player == ChessPlayer.BLACK)
        {
            foreach (Renderer s in renderers)
            {
                s.material.color = Color.red;
            }
        }
    }
    public virtual void Move()
    {
        Debug.LogError("MOVE NOT IMPLEMENTED");
    }
<<<<<<< HEAD
>>>>>>> Included Instantiation of the board
=======

    
>>>>>>> Inclded instantiation of Pawns
}
