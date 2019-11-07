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

    public void SetColorOfTile(bool isBlack)
    {
        if (isBlack)
        {
            GameRenderer.material = BlackMat;
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

    public string containsObject()
    {
        return "HEHE";
    }

    public void SetTilePosition(Vector3 pos)
    {
        this.gameObject.transform.position = pos;
    }
}
