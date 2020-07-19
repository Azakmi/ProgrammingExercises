using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermediate6
{
    public class MorseCoder
    {
        static readonly Dictionary<string, string> morseLookupTable = new Dictionary<string, string>() { };
        
        /// <summary>
        /// Returns Morse representation of passed input character
        /// </summary>
        /// <param name="inputChar">Character to be converterd to Morse</param>
        public string GetCharAsMorse(string inputChar)
        {
            return morseLookupTable.FirstOrDefault(x => x.Key == inputChar).Value;
        }

        /// <summary>
        /// Decodes Morse representation to character
        /// </summary>
        /// <param name="inputMorse">Morse string to be decoded</param>
        public string GetMorseAsChar(string inputMorse)
        {
            return morseLookupTable.FirstOrDefault(x => x.Value == inputMorse).Key;
        }
    }
}
