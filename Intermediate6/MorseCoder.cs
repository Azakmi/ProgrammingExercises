using System.Collections.Generic;
using System.Linq;

namespace Intermediate6
{
    /// <summary>
    /// Base class for MorseEncoder and MorseDecoder, for character level coding and decoding morse data
    /// </summary>
    public class MorseCoder
    {
        /// <summary>
        /// Pre-constructed dictionary containing the ITU standard morse code table.
        /// </summary>
        static readonly Dictionary<char, string> morseLookupTable = new Dictionary<char, string>()
        {
            {'A', ".-" },
            {'B', "-..." },
            {'C', "-.-." },
            {'D', "-.." },
            {'E', "." },
            {'F', "..-." },
            {'G', "--." },
            {'H', "...." },
            {'I', ".." },
            {'J', ".---" },
            {'K', "-.-" },
            {'L', ".-.." },
            {'M', "--" },
            {'N', "-." },
            {'O', "---" },
            {'P', ".--." },
            {'Q', "--.-" },
            {'R', ".-." },
            {'S', "..." },
            {'T', "-" },
            {'U', "..-" },
            {'V', "...-" },
            {'W', ".--" },
            {'X', "-..-" },
            {'Y', "-.--" },
            {'Z', "--.." },
            {'0', "-----" },
            {'1', ".----" },
            {'2', "..---" },
            {'3', "...--" },
            {'4', "....-" },
            {'5', "....." },
            {'6', "-...." },
            {'7', "--..." },
            {'8', "---.." },
            {'9', "----." },
            {' ', " " }
        };

        /// <summary>
        /// Returns Morse representation of passed input character
        /// </summary>
        /// <param name="inputChar">Character to be converterd to Morse</param>
        public static string GetCharAsMorse(char inputChar)
        {
            if (morseLookupTable.ContainsKey(char.ToUpperInvariant(inputChar)))
            {
                return morseLookupTable.First(x => x.Key == char.ToUpperInvariant(inputChar)).Value;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("inputChar", "Passed character not in decoding table");
            }
        }

        /// <summary>
        /// Decodes Morse representation to character
        /// </summary>
        /// <param name="inputMorse">Morse string to be decoded</param>
        public static char GetMorseAsChar(string inputMorse)
        {
            if (morseLookupTable.ContainsValue(inputMorse))
            {
                return morseLookupTable.FirstOrDefault(x => x.Value == inputMorse).Key;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("inputMorse", "Passed input not valid morse");
            }
        }
    }
}
