using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Dylan Burnham
A class to store all of the information about a board. Allows the game to check board squares for wether or not they are
preseed, flagged, and determine the squares value. It is also used to set up the game.
Note we talked about the swapping of rows and cols and i was told that it was ok, just to add a comment in my solution
cols = xPosition/xThreeByThree
rows = yPosition / yThreeByThree
*/

namespace MineSweeper
{
    
    internal class Board
    {
        public const int MINESQUARE = -1;

        private BoardSquare[,] gameBoard;

        private int pressedTiles = 0;
        public int BoardSizeX { get; set; }
        public int BoardSizeY { get; set; }
        public int NumberOfMines { get; set; }
        public int NumberOfFlags { get; set; }

        // Default constructor to initialize the board class
        public Board(int boardSizeX, int boardSizeY, int numberOfMines)
        {
            gameBoard = new BoardSquare[boardSizeX, boardSizeY];
            BoardSizeX = boardSizeX;
            BoardSizeY = boardSizeY;
            NumberOfMines = numberOfMines;
            NumberOfFlags = numberOfMines;
            LoadGameBoard();
            LoadMines();
            LoadNumbers();
        }

        // Create the game board based off of the specific size values
        public void LoadGameBoard()
        {
            for(int xPosition = 0; xPosition < BoardSizeX; xPosition++)
            {
                for(int yPosition = 0; yPosition < BoardSizeY; yPosition++)
                {
                    gameBoard[xPosition, yPosition] = new BoardSquare();
                }
            }
        }

        // Load in the mines using random number generation
        private void LoadMines()
        {
            for(int index = 0; index < NumberOfMines; index++)
            {
                Random randomGen = new Random();
                int xPosition = randomGen.Next(BoardSizeX);
                int yPosition = randomGen.Next(BoardSizeY);
                while (gameBoard[xPosition, yPosition].Value == MINESQUARE)
                {
                    xPosition = randomGen.Next(BoardSizeX);
                    yPosition = randomGen.Next(BoardSizeY);
                }
                gameBoard[xPosition, yPosition].Value = MINESQUARE;
            }
        }

        // Load in the numbers by checking if a square has mines around it
        private void LoadNumbers()
        {
            for(int xPosition = 0; xPosition < BoardSizeX; xPosition++)
            {
                for(int yPosition = 0; yPosition < BoardSizeY; yPosition++)
                {
                    if (gameBoard[xPosition, yPosition].Value != MINESQUARE)
                    {
                        gameBoard[xPosition, yPosition].Value = CheckSurroundingSquares(xPosition, yPosition);
                    }
                }
            }
        }

        // Used to check if there is a mine in the surrounding squares, if so increment the counter
        private int CheckSurroundingSquares(int xPosition, int yPosition)
        {
            int mineCount = 0;
            for(int xThreeByThree = xPosition - 1; xThreeByThree <= xPosition + 1; xThreeByThree++)
            {
                for(int yThreeByThree = yPosition - 1; yThreeByThree <= yPosition + 1; yThreeByThree++)
                {
                    if(xThreeByThree >= 0 && xThreeByThree < BoardSizeX && yThreeByThree >= 0 && yThreeByThree < BoardSizeY)
                    {
                        if (gameBoard[xThreeByThree, yThreeByThree].Value == MINESQUARE)
                        {
                            mineCount++;
                        }
                    }
                }
            }
            return mineCount;
        }

        // Return the board squares value (-1 for mines)
        public int GetBoardSquareValue(int xPosition, int yPosition)
        {
            return gameBoard[xPosition, yPosition].Value;   
        }

        // Check if the board square is pressed or not
        public bool GetBoardSquarePressed(int xPosition, int yPosition)
        {
            return gameBoard[xPosition, yPosition].Pressed;
        }

        // Set the board square state and update pressed tiles to determine win condition
        public void SetBoardSquarePressed(int xPosition, int yPosition)
        {
            if(!gameBoard[xPosition, yPosition].Pressed)
            {
                pressedTiles++;
                gameBoard[xPosition, yPosition].Pressed = true;
            }
        }

        // Update the flagged status of a game board tile and update number of flags accordingly
        public void SetBoardSquareFlagged(int xPosition, int yPosition, bool flagged)
        {
            if(flagged)
            {
                if(NumberOfFlags > 0)
                {
                    NumberOfFlags--;
                    gameBoard[xPosition, yPosition].Flagged = flagged;
                }    
            }
            else
            {
                NumberOfFlags++;
                gameBoard[xPosition, yPosition].Flagged = flagged;
            }
        }

        // Check if a board square has been flagged or not
        public bool GetBoardSquareFlagged(int xPosition, int yPosition)
        {
            return gameBoard[xPosition, yPosition].Flagged;
        }

        // Check if a player has beaten the game 
        public bool HasWon()
        {
            bool won = false;
            if(pressedTiles == BoardSizeX * BoardSizeY - NumberOfMines)
            {
                won = true;
            }
            return won;
        }
    }
}
