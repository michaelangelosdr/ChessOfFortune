using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Managers_Controllers
{
    public class ChessManager : IManager
    {
        [SerializeField]
        Transform WhitePieces;

        [SerializeField]
        Transform BlackPieces;

<<<<<<< HEAD
<<<<<<< HEAD
        [SerializeField]
        List<ChessToken> tokens;


=======

        [SerializeField]
        List<ChessToken> tokens;

>>>>>>> Inclded instantiation of Pawns
=======
        [SerializeField]
        List<ChessToken> tokens;


>>>>>>> Included new IDLE state in which the player can now select a spot
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void TryMove(ChessToken piece, ChessTile tile)
        {
            if (tile.CurrentObject == TileObject.ENEMY)
            {
                Debug.Log("CONSUME ENEMY");
                //Consume
            }
            else if (tile.CurrentObject == TileObject.NULL)
            {
                piece.Move();
                //Move
            }
<<<<<<< HEAD
<<<<<<< HEAD
        }

        //================ CHESS OBJECT SETTER ==============================
        public void SetallPieces(ChessPlayer player,Dictionary<Point,ChessTile> grid)
        {
            SetPawns(player,grid);         
            SetRook(player,grid);
            SetBishop(player,grid);
            SetHorse(player,grid);
            SetQueen(player, grid);
            SetKing(player,grid);
        }


        private void SetPawns(ChessPlayer player, Dictionary<Point,ChessTile> grid)
=======

=======
>>>>>>> Included new IDLE state in which the player can now select a spot
        }

        //================ CHESS OBJECT SETTER ==============================
        public void SetallPieces(ChessPlayer player,Dictionary<Point,ChessTile> grid)
        {
            SetPawns(player,grid);         
            SetRook(player,grid);
            SetBishop(player,grid);
            SetHorse(player,grid);
            SetQueen(player, grid);
            SetKing(player,grid);
        }


<<<<<<< HEAD
        private void SetPawns(ChessPlayer player)
>>>>>>> Inclded instantiation of Pawns
=======
        private void SetPawns(ChessPlayer player, Dictionary<Point,ChessTile> grid)
>>>>>>> Included new IDLE state in which the player can now select a spot
        {
            for (int x = 0; x < 8; x++)
            {
                PawnToken pawn = null;
                if(player == ChessPlayer.WHITE)
                {
                    pawn = Instantiate(tokens[(int)ChessTokenType.PAWN], WhitePieces) as PawnToken;
<<<<<<< HEAD
<<<<<<< HEAD
                    grid[new Point(6, x)].Current_Token = pawn;
                }
                else if(player == ChessPlayer.BLACK)
                {
                    pawn = Instantiate(tokens[(int)ChessTokenType.PAWN], BlackPieces) as PawnToken;
                    grid[new Point(1, x)].Current_Token = pawn;
                    
=======
                }
                else if(player == ChessPlayer.BLACK)
                {
                    pawn = Instantiate(tokens[(int)ChessTokenType.PAWN], BlackPieces) as PawnToken; 
>>>>>>> Inclded instantiation of Pawns
=======
                    grid[new Point(6, x)].Current_Token = pawn;
                }
                else if(player == ChessPlayer.BLACK)
                {
                    pawn = Instantiate(tokens[(int)ChessTokenType.PAWN], BlackPieces) as PawnToken;
                    grid[new Point(1, x)].Current_Token = pawn;
                    
>>>>>>> Included new IDLE state in which the player can now select a spot
                }
                pawn.Initialize(player);
                pawn.transform.localPosition = new Vector3(0, 0, (x * 1));
            }
        }

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> Included new IDLE state in which the player can now select a spot
        private void SetRook(ChessPlayer player, Dictionary<Point, ChessTile> grid)
        {
            RookToken rook = null;
            for (int x=0;x<2;x++)
            { 
            if(player == ChessPlayer.BLACK)
            {
                rook = Instantiate(tokens[(int)ChessTokenType.ROOK],BlackPieces) as RookToken;
                rook.transform.localPosition = new Vector3(1, 0, (7 * x));
                    grid[new Point(7, 7*x)].Current_Token = rook;
                }
            else if(player == ChessPlayer.WHITE)
            {
                rook = Instantiate(tokens[(int)ChessTokenType.ROOK], WhitePieces) as RookToken;
                rook.transform.localPosition = new Vector3(-1, 0, (7 * x));
                grid[new Point(0, 7 * x)].Current_Token = rook;
                }
                rook.Initialize(player);
            }
           
        }

        private void SetHorse(ChessPlayer player, Dictionary<Point, ChessTile> grid)
        {
            HorseToken horse = null;

            for(int x=6;x>0;x-=5)
            {
                if (player == ChessPlayer.BLACK)
                {
                    horse = Instantiate(tokens[(int)ChessTokenType.HORSE], BlackPieces) as HorseToken;
                    horse.transform.localPosition = new Vector3(1, 0, x);
                    grid[new Point(7, x)].Current_Token = horse;
                }
                else if (player == ChessPlayer.WHITE)
                {
                    horse = Instantiate(tokens[(int)ChessTokenType.HORSE], WhitePieces) as HorseToken;
                    horse.transform.localPosition = new Vector3(-1, 0, x);
                    grid[new Point(0, x)].Current_Token = horse;
                }
                horse.Initialize(player);
            }

        
        }
        private void SetBishop(ChessPlayer player, Dictionary<Point, ChessTile> grid)
<<<<<<< HEAD
        {
            BishopToken bishop = null;
            for(int x = 5; x>0; x-=3)
            {
                if(player == ChessPlayer.BLACK)
                {
                    Debug.Log("Im called");
                    bishop = Instantiate(tokens[(int)ChessTokenType.BISHOP], BlackPieces) as BishopToken;
                    bishop.transform.localPosition = new Vector3(1, 0, x);
                    grid[new Point(7, x)].Current_Token = bishop;
                }
                else if(player == ChessPlayer.WHITE)
                {
                    bishop = Instantiate(tokens[(int)ChessTokenType.BISHOP], WhitePieces) as BishopToken;
                    bishop.transform.localPosition = new Vector3(-1, 0, x);
                    grid[new Point(0, x)].Current_Token = bishop;
                }
                bishop.Initialize(player);
            }

          
        }

        private void SetQueen(ChessPlayer player, Dictionary<Point, ChessTile> grid)
        {
            QueenToken queen = null;
            
            if(player == ChessPlayer.BLACK)
            {
                queen = Instantiate(tokens[(int)ChessTokenType.QUEEN], BlackPieces) as QueenToken;
                queen.transform.localPosition = new Vector3(1, 0, 3);
                grid[new Point(7,3)].Current_Token = queen;
            }
            else
            {
                queen = Instantiate(tokens[(int)ChessTokenType.QUEEN], WhitePieces) as QueenToken;
                queen.transform.localPosition = new Vector3(-1, 0, 4);
                grid[new Point(0, 4)].Current_Token = queen;
            }
            queen.Initialize(player);
        }
        private void SetKing(ChessPlayer player, Dictionary<Point, ChessTile> grid)
        {
          KingToken King = null;
            if (player == ChessPlayer.BLACK)
            {
                King = Instantiate(tokens[(int)ChessTokenType.KING], BlackPieces) as KingToken;
                King.transform.localPosition = new Vector3(1, 0, 4);
                grid[new Point(7, 4)].Current_Token = King;
            }
            else
            {
                King = Instantiate(tokens[(int)ChessTokenType.KING], WhitePieces) as KingToken;
                King.transform.localPosition = new Vector3(-1, 0, 3);
                grid[new Point(0, 3)].Current_Token = King;
            }
           King.Initialize(player);
=======
        private void SetRook(ChessPlayer player)
=======
>>>>>>> Included new IDLE state in which the player can now select a spot
        {
            BishopToken bishop = null;
            for(int x = 5; x>0; x-=3)
            {
                if(player == ChessPlayer.BLACK)
                {
                    Debug.Log("Im called");
                    bishop = Instantiate(tokens[(int)ChessTokenType.BISHOP], BlackPieces) as BishopToken;
                    bishop.transform.localPosition = new Vector3(1, 0, x);
                    grid[new Point(7, x)].Current_Token = bishop;
                }
                else if(player == ChessPlayer.WHITE)
                {
                    bishop = Instantiate(tokens[(int)ChessTokenType.BISHOP], WhitePieces) as BishopToken;
                    bishop.transform.localPosition = new Vector3(-1, 0, x);
                    grid[new Point(0, x)].Current_Token = bishop;
                }
                bishop.Initialize(player);
            }

<<<<<<< HEAD
>>>>>>> Inclded instantiation of Pawns
=======
          
        }

        private void SetQueen(ChessPlayer player, Dictionary<Point, ChessTile> grid)
        {
            QueenToken queen = null;
            
            if(player == ChessPlayer.BLACK)
            {
                queen = Instantiate(tokens[(int)ChessTokenType.QUEEN], BlackPieces) as QueenToken;
                queen.transform.localPosition = new Vector3(1, 0, 3);
                grid[new Point(7,3)].Current_Token = queen;
            }
            else
            {
                queen = Instantiate(tokens[(int)ChessTokenType.QUEEN], WhitePieces) as QueenToken;
                queen.transform.localPosition = new Vector3(-1, 0, 4);
                grid[new Point(0, 4)].Current_Token = queen;
            }
            queen.Initialize(player);
        }
        private void SetKing(ChessPlayer player, Dictionary<Point, ChessTile> grid)
        {
          KingToken King = null;
            if (player == ChessPlayer.BLACK)
            {
                King = Instantiate(tokens[(int)ChessTokenType.KING], BlackPieces) as KingToken;
                King.transform.localPosition = new Vector3(1, 0, 4);
                grid[new Point(7, 4)].Current_Token = King;
            }
            else
            {
                King = Instantiate(tokens[(int)ChessTokenType.KING], WhitePieces) as KingToken;
                King.transform.localPosition = new Vector3(-1, 0, 3);
                grid[new Point(0, 3)].Current_Token = King;
            }
           King.Initialize(player);
>>>>>>> Included new IDLE state in which the player can now select a spot
        }

    }

    public enum ChessPlayer
    {
        WHITE,
        BLACK
    }
}