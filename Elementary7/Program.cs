using System;

namespace Elementary7
{
    class Program
    {
        /// <summary>
        /// Write a program that prints a multiplication table for numbers up to 12.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int tableSize = 12;

            for (int i = 1; i <= tableSize; i++)
            {
                for (int j = 1; j <= tableSize; j++)
                {
                    Console.Write($"{ i*j,3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
