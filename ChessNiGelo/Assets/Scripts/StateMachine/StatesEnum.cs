﻿public enum States
{
    //BOARD_GAME CHECK // Checks which game to be played
    BOARD_INITIALIZIATION_STATE =0, //Create board
    BOARD_SETUP_STATE = 1, //Instantiate Stuff on the board 
    WHITE_PIECE_IDLE_STATE =2, //Enable Input handler for this
    WHITE_PIECE_SELECTED_STATE =3, //Show all the possible moves for  the selected piece
    WHITE_PIECE_ACTION_STATE=4, //Move to the tile and check
    MID_ROUND_CALCULATIONS_STATE =5, // Check if player wins here 
    
    //AI States

    
}