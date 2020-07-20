using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate6
{
    public class MorseEncoder: MorseCoder
    {
        public string EncodeString(string inputString)
        {
            if (IsInputValid(inputString))
            {
                string result = "";

                //TODO

                return result;
            }
            else
            {
                return string.Empty;
            }
        }

        private bool IsInputValid(string inputString)
        {
            throw new System.NotImplementedException();
        }
    }
}