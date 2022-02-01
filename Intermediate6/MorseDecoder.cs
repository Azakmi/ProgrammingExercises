using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Intermediate6
{
    public class MorseDecoder: MorseCoder, InputValidator
    {
        public string DecodeString(string inputString)
        {
            if (IsInputValid(inputString))
            {
                StringBuilder sb = new StringBuilder();
                foreach( string substring in inputString.Split(' '))
                {
                    if (!string.IsNullOrEmpty(substring))
                    {
                        sb.Append(GetMorseAsChar(substring));
                    }
                    else
                    {
                        // Only put one space between words
                        if (!sb.ToString().EndsWith(" ")) { sb.Append(' '); }
                    }
                }
                return sb.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public bool IsInputValid(string inputString)
        {
            return new Regex($"^[.\\- ]*$").IsMatch(inputString);
        }
    }
}