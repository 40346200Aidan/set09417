using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApplication
{
    
    class Gameboard
    {
        //Initialise 2D array to contain game board
        int[,] board = { { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                         { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

        public int[,] getBoard()
        {

            return board;
        }
        
        public Gameboard()
        {

             
        }

        //Method to displaye the game board (borders)
        public void ShowBoard()
        {
            string strBoard = "";

            strBoard += "--------------------------------------------------\n";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    
                    if (board[i, j] == 0)
                    {
                        strBoard += "|    |";

                    }
                    else
                    {
                        strBoard += "| " + board[i, j] + " |";
                    }

                }
                strBoard += "\n";
            }
            strBoard += "--------------------------------------------------\n";
            Console.WriteLine(strBoard);
        }

        public void UpdateCell(int x, int y, int value)
        {
            board[x, y] = value;
            

        }
    }
}
