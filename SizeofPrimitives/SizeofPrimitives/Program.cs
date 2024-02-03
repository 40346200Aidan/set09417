using System;

namespace SizeOfPrimitives
{
    class Program
    {

        //There are 13 primitive data types in c#
        /*
         * byte
         * sbyte
         * ushort
         * uint
         * int
         * ulong
         * float
         * double
         * decimal
         * char
         * bool
         */
        static void Main(string[] args)
        {
            byte a = 1;
            Console.WriteLine("Size of byte = " + sizeof(byte) + " byte");

            sbyte b = 1;
            Console.WriteLine("Size of sbyte = " + sizeof(sbyte) + " byte");

            ushort c = 1;
            Console.WriteLine("Size of uShort = " + sizeof(ushort) + " bytes");

            uint d = 1;
            Console.WriteLine("Size of uint = " + sizeof(uint) + " bytes");

            int e = 1;
            Console.WriteLine("Size of int = " + sizeof(int) + " bytes");

            ulong f = 1;
            Console.WriteLine("Size of ulong = " + sizeof(ulong) + " bytes");

            float g = 1;
            Console.WriteLine("Size of float = " + sizeof(float) + " bytes");

            double h = 1;
            Console.WriteLine("Size of double = " + sizeof(double) + " bytes");

            decimal i = 1;
            Console.WriteLine("Size of decimal = " + sizeof(decimal) + " bytes");

            char j = 'j';
            Console.WriteLine("Size of Char = " + sizeof(char) + " bytes");

            bool k = false;
            Console.WriteLine("Size of bool = " + sizeof(bool) + " byte");

            //Breaking up sections of the labs

            Console.WriteLine("Size of byte : " + sizeof(byte) + " bytes.");
            Console.WriteLine("Size of int : " + sizeof(int) + " bytes.");
            Console.WriteLine("Size of long : " + sizeof(long) + " bytes.");
            Console.WriteLine("Size of Character : " + sizeof(char) + " bytes.");
            Console.WriteLine("Size of float : " + sizeof(float) + " bytes.");
            Console.WriteLine("Size of float : " + sizeof(double) + " bytes.");

            Console.ReadLine();

        }
    }
}