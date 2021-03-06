using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Board
    {
        //Data is stroed in a 3X3 2D array of integers
        //Empty cells are represented with 0
        //X cells are represented with 1
        //O cells are represented with 2

        private int[,] pattern;

        public Board()
        {
            // 3x3 board
            pattern = new int[3,3];
            clearBoard();
        }
        public void clearBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pattern[i,j] = 0;
                }
            }
        }

        public bool addCounter(int playerID, int xPos, int yPos)
        {
            bool result = false;
            if (pattern[xPos, yPos] == 0)
            {
                pattern[xPos, yPos] = playerID;
                result = true;
            }
            else if ((pattern[xPos, yPos] > 2) || (pattern[xPos, yPos] < 0))
            {
                //Value out of bounds
                Console.WriteLine("Error report: position value out of bounds");
                result = false;
            }
            return result;
        }
        public int checkwin()
        {
            // 0 - Draw
            // 1 - Player 1 wins
            // 2 - Player 2 wins
            // 3 - no Win -> continue

            //Variables
            int result = 3;
            bool BoardComplete = true;

            //check for column & row wins
            for (int i = 0; i < 3; i++)
            {
                //Row check
                if (pattern[i, 0] == pattern[i, 1] &&
                    pattern[i, 0] == pattern[i, 2] &&
                    pattern[i, 0] != 0)
                {
                    result = pattern[i, 0];
                }
                //Column check
                else if (pattern[0, i] == pattern[1, i] &&
                    pattern[0, i] == pattern[2, i] &&
                    pattern[0, i] != 0)
                {
                    result = pattern[0, i];
                }
            }

            //check for diagonal wins
            if (pattern[0, 0] == pattern[1, 1] &&
                pattern[0, 0] == pattern[2, 2] &&
                pattern[0, 0] != 0)
            {
                result = pattern[0, 0];
            }
            else if (pattern[2, 0] == pattern[1, 1] &&
                pattern[2, 0] == pattern[0, 2] &&
                pattern[2, 0] != 0)
            {
                result = pattern[2, 0];
            }

            //if there is no win yet, then check for draw
            if (result == 3)
            {
                //check if board is full
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (pattern[i, j] == 0)
                        {
                            BoardComplete = false;
                        }
                    }
                }
                //if board is full and there is no win yet
                if (BoardComplete == true)
                {
                    result = 0;
                }
            }

            return result;
        }
        public int GetPos(int xPos, int yPos)
        {
            return (pattern[xPos, yPos]);
        }
    }
}
