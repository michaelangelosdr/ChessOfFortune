using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    //would be the base class of game tiles.
    protected string ID;
<<<<<<< HEAD
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

=======
    public Point Position;
>>>>>>> Included new IDLE state in which the player can now select a spot
    
>>>>>>> Included Instantiation of the board
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
}
