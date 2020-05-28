using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    
}
