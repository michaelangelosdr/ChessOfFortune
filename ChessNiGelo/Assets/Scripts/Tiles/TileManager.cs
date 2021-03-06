﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Managers_Controllers
{

    public class TileManager : IManager
    {

        [SerializeField]
        private BoardType btype;

        [SerializeField]
        private int boardSize;

        [SerializeField]
        List<Tile> TilesPrefab;

       public Dictionary<Point, ChessTile> GameGrid;

        [SerializeField]
        TextMesh BoardText;

        [SerializeField]
        GameObject TextHolder;


        public void Init()
        {
            GameGrid = new Dictionary<Point, ChessTile>();
            CreateBoard(btype);
        }

        private void CreateBoard(BoardType type)
        {
            if (type == BoardType.CHESS)
            {
                CreateChessBoard();
            }
        }


        private void CreateChessBoard()
        {
            bool isBlack = false;
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    ChessTile chessTile = Instantiate(TilesPrefab[(int)btype], this.transform) as ChessTile;
                    Point p = new Point(row, col);
                    chessTile.Position = p;                    
                    GameGrid.Add(p, chessTile);

                    chessTile.SetColorOfTile(isBlack);
                    isBlack = !isBlack;
                    chessTile.Set_StringID((alphabet[row] + (col + 1).ToString()).ToString());
                    chessTile.SetTilePosition(new Vector3(row, 0, col));


                    /*TextMesh testing = Instantiate(BoardText, this.transform);
                    testing.text = row.ToString() + "," + col.ToString();
                    testing.transform.localPosition = new Vector3(row, 0, col);*/

                }

                TextMesh Atext = Instantiate(BoardText, TextHolder.transform);
                Atext.text = alphabet[row].ToString();
                Atext.transform.localPosition = new Vector3(0, -(row * 1.12f), 0);

                TextMesh Ntext = Instantiate(BoardText, TextHolder.transform);
                Ntext.text = (row + 1).ToString();
                Ntext.transform.localPosition = new Vector3((row + 1.5f), 1.0f, 0);

                isBlack = !isBlack;
            }

        }

        public Tile GetPosition(Point p)
        {
            return TilesPrefab.Find(x => x.Position == p);
        }

    }
}
