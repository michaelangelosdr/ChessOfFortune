using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessTile : Tile, IContain
{
    [SerializeField]
    Material BlackMat;

    [SerializeField]
    Material WhiteMat;

    [SerializeField]
    Renderer GameRenderer;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> Included new IDLE state in which the player can now select a spot
    [SerializeField]
    private ChessToken currentToken;
    Color tmp = new Color();

    public TileObject CurrentObject { get { return CurrentObject; } set { CurrentObject = value; } }

    public ChessToken Current_Token
    {
        get { return currentToken; }
        set { currentToken = value; }
    }

    public ChessTile IsSelected(bool p_isSelected)
    {
        
        if(p_isSelected)
        {
            tmp = GameRenderer.material.color;
            GameRenderer.material.color = Color.red;
        }
        else
        {
            GameRenderer.material.color = tmp;
            
        }
        return this;
    }

<<<<<<< HEAD
=======
>>>>>>> Included Instantiation of the board
=======

    public TileObject CurrentObject { get { return CurrentObject; } set { CurrentObject = value; } }

>>>>>>> Inclded instantiation of Pawns
=======
>>>>>>> Included new IDLE state in which the player can now select a spot
    public void SetColorOfTile(bool isBlack)
    {
        if (isBlack)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            GameRenderer.material.color = Color.gray;
=======
            GameRenderer.material = BlackMat;
>>>>>>> Included Instantiation of the board
=======
            GameRenderer.material.color = Color.gray;
>>>>>>> Included new IDLE state in which the player can now select a spot
        }
        else
        {
            GameRenderer.material = WhiteMat;
        }
    }

    public void Set_StringID(string ID)
    {
        this.ID = ID;
        gameObject.name = ID;
    }

    public string Get_StringID()
    {
        return this.ID;
    }

<<<<<<< HEAD
<<<<<<< HEAD
=======
    public string containsObject()
    {
        return "HEHE";
    }
>>>>>>> Included Instantiation of the board
=======
>>>>>>> Inclded instantiation of Pawns

    public void SetTilePosition(Vector3 pos)
    {
        this.gameObject.transform.position = pos;
    }
}
