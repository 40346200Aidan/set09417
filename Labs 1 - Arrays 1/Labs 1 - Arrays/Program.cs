using System;
using System.Security.Cryptography;

namespace Lab1Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //Declare an Array to store first year grades
            string[] grades = { "A", "B", "C", };

            //Alter array to add 2nd year grades
            string[] temp = new string[grades.Length + 1];
            for(int i = 0; i < grades.Length; i++)
            {
                temp[i] = grades[i];
                grades = temp;
                Console.WriteLine("Please enter one of your 2nd year grades");
                grades[i] = Console.ReadLine();
            }

            //Display array values
            for (int i = 0;i < grades.Length;i++)
            {
                Console.WriteLine(grades[i]);
            }

            
        }

        
    }
}