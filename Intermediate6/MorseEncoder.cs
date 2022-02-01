using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Intermediate6
{
    public class MorseEncoder : MorseCoder, InputValidator
    {
        public string EncodeString(string inputString)
        {
            if (IsInputValid(inputString))
            {
                StringBuilder sb = new StringBuilder();

                foreach (char c in inputString)
                { sb.Append(GetCharAsMorse(c) + " "); }
                sb.Remove(sb.Length - 1, 1);

                return sb.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public bool IsInputValid(string inputString)
        {
            return new Regex($"^[a-zA-Z0-9 ]*$").IsMatch(inputString);
        }

    }
}