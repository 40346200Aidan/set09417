using SudokuApplication;
using System;

namespace SudokuApplicaiton
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Menu mainMenu = new Menu();

            Welcome();

            mainMenu.showMenu();


            Console.ReadLine();
        }

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
    }
}