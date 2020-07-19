using System;

namespace Elementary4
{
    class Program
    {
        /// <summary>
        /// Write a program that asks the user for a number n and prints the sum of the numbers 1 to n
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Program asks for integer number, return sum of numbers of 1..n");
            Console.Write("Enter integer: ");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int convertedNumber))
            {
                Console.WriteLine("Entered value is not an integer");
            }
            else
            {
                int sum = 0;
                if (convertedNumber >= 1)
                {
                    for (int i = 1; i <= convertedNumber; i++)
                    {
                        sum += i;
                    }
                }
                else
                {
                    for (int i = 1; i >= convertedNumber; i--)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine($"Sum of numbers 1..n is: {sum}");
            }
        }
    }
}
