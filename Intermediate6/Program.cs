using System;

namespace Intermediate6
{
    class Program
    {
        /// <summary>
        /// Write a program that automatically converts English text to Morse code and vice versa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MorseDecoder decoder = new MorseDecoder();
            MorseEncoder encoder = new MorseEncoder();

            Console.WriteLine("Enter a text to encode or decode");
            string UserInput = Console.ReadLine();

            if (decoder.IsInputValid(UserInput))
            {
                Console.WriteLine(decoder.DecodeString(UserInput));
            }
            else if (encoder.IsInputValid(UserInput))
            { 
                Console.WriteLine(encoder.EncodeString(UserInput)); 
            }
            else { Console.WriteLine("Input cannot be encoded or decoded"); }

            //Just to keep window open until user presses enter
            Console.ReadLine();


        }
    }
}
