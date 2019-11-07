using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    //would be the base class of game tiles.
    protected string ID;
<<<<<<< HEAD
    public Point Position;
    
}

public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public static bool operator ==(Point a, Point b)
    {
        return a.X == b.X && a.Y == b.Y;
    }

    public static bool operator !=(Point a, Point b)
    {
        return a.X != b.X && a.Y != b.Y;
    }
=======

    
>>>>>>> Included Instantiation of the board
}
