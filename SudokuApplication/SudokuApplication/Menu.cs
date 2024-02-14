using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApplication
{
    class Menu
    {
        //initialise states that the game can be in at any time
        public State notStarted, easystarted, mediumStarted, hardStarted, exit, movement;
        
        public Menu()
        {

            notStarted = new State(0, "not Started");
            easystarted = new State(1, "easy Started");
            mediumStarted = new State(2, "medium Started");
            hardStarted = new State(3, "hard Started");
            exit = new State(4, "exit Game");
            movement = new State(5, "movement");

            notStarted.actions = new string[] { "start easy game" , "start medium game", "start hard game", "exit"};
            movement.actions = new string[] { "Next move", "exit" , "redo" , "undo"};
            easystarted.actions = new string[] { "Next move", "exit" };
            mediumStarted.actions = new string[] { "Next move", "exit" };
            hardStarted.actions = new string[] { "Next move", "exit" };


            currentState = notStarted;
        }

        public State currentState = new State(-1, "Nothing");

        State[] states = new State[10];

        public void showMenu()
        {
            for (int i = 0; i < currentState.actions.Length; i++)
            {

                Console.WriteLine((i + 1) + ") " + currentState.actions[i]);

            }


        }

        public void callAction(string actionName)
        {
            
            switch (actionName)
            {
                case "start easy game":
                    currentState = easystarted;
                    break;
                case "start medium game":
                    currentState = mediumStarted;
                    break;
                case "start hard game":
                    currentState = hardStarted;
                    break;
                case "exit":
                    currentState = exit;
                    System.Environment.Exit(0);
                    break;
                case "Next move":
                    currentState = movement;
                    int x, y, value;
                    Console.WriteLine("x: ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("y: ");
                    y = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("value: ");
                    value = Int32.Parse(Console.ReadLine());
                    break;
                case "undo":
                    currentState = movement;
                    break;
                case "redo":
                    currentState = movement;
                    break;
                   
            }



        }

        public void selectAction(int playerChoice)
        {
            this.callAction(currentState.actions[playerChoice]);

        }

        public void changesState()
        {


        }
    }
}
