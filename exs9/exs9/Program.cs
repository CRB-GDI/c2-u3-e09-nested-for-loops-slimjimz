﻿using System.Globalization;

namespace exs9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row width: ");
            int rowWidth = int.Parse(Console.ReadLine());
            Console.Write("Enter number of rows: ");
            int numRows =int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for (int i = 1; i <= numRows; i++)
            {
                for (int j = 1; j <= rowWidth; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }




        }
    }
}