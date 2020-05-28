using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IContain
{

    TileObject CurrentObject { get; set; }

    
}

public enum TileObject
{
    FRIEND,
    ENEMY,
    NULL
}
