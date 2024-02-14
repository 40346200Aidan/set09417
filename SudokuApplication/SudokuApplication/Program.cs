using SudokuApplication;
using System;

namespace SudokuApplicaiton
{
    class Program
    {
        //Main method (Entry point for the program)
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Menu mainMenu = new Menu();

            Welcome();
            Gameboard gameboard = new Gameboard();
            gameboard.ShowBoard();

            while (true)
            {
                playerInput(mainMenu);

            }
           

            
           

            Console.ReadLine();
        }

        //Method to welcome player to the game and retrieve some details
        static void Welcome()
        {
            string playerName;
            int playerAge = 0;

            Console.WriteLine("-----------------------");
            Console.WriteLine("| Welcome to Sudoku!! |");
            Console.WriteLine("----------------------", "\n");

            Console.WriteLine("Please enter your name");
            playerName = Console.ReadLine();

            Console.WriteLine("Welcome! " +  playerName);
            Console.WriteLine(playerName + ", Please enter your age");
            playerAge = Int32.Parse(Console.ReadLine());

            //if statement to display difficulty recommendation depending on player age
            if (playerAge <= 16)
            {
                Console.WriteLine("Based on your age we think you'd find the easy difficulty the most challenging.");

            } else if(playerAge >= 17 && playerAge <= 25)
            {
                Console.WriteLine("Based on your age we think you'd find the medium difficulty the most challenging");
            }
            else
            {
                Console.WriteLine("Based on your age we think you'd find the hard difficulty the most challenging");
            }

        }

        //Method to get user input for game mode selection
        static void playerInput(Menu menu)
        {
            int playerInput;
            menu.showMenu();

            Console.WriteLine("Please choose: ");
            playerInput = Int32.Parse(Console.ReadLine());
            menu.selectAction(playerInput - 1);
        }

    }
}