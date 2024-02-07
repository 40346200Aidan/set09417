using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApplication
{
    class Menu
    {
        public Menu()
        {

            State notStarted = new State(0, "not Started");
            State easystarted = new State(1, "easy Started");
            State mediumStarted = new State(2, "medium Started");
            State hardStarted = new State(3, "hard Started");
            State quit = new State(4, "exit Game");

            notStarted.actions = new string[] { "start easy game" , "start medium game", "start hard game", "exit"};




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

        public void callAction()
        {


        }

        public void selectAction()
        {


        }

        public void changesState()
        {


        }
    }
}
