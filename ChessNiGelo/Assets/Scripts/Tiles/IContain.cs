using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IContain
{
<<<<<<< HEAD

    TileObject CurrentObject { get; set; }

    
}

public enum TileObject
{
    FRIEND,
    ENEMY,
    NULL
=======
    string containsObject();
>>>>>>> Included Instantiation of the board
}
