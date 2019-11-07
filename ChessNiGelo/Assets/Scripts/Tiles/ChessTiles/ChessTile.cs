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

=======
>>>>>>> Included Instantiation of the board
    public void SetColorOfTile(bool isBlack)
    {
        if (isBlack)
        {
<<<<<<< HEAD
            GameRenderer.material.color = Color.gray;
=======
            GameRenderer.material = BlackMat;
>>>>>>> Included Instantiation of the board
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
=======
    public string containsObject()
    {
        return "HEHE";
    }
>>>>>>> Included Instantiation of the board

    public void SetTilePosition(Vector3 pos)
    {
        this.gameObject.transform.position = pos;
    }
}
