using Microsoft.VisualStudio.TestTools.UnitTesting;
using Intermediate6;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate6.Tests
{
    [TestClass()]
    public class MorseCoderTests
    {
        /// <summary>
        /// Tests a character conversion in English->Morse direction
        /// </summary>
        [TestMethod()]
        public void CharToMorseValid()
        {
            Assert.AreEqual("--.", MorseCoder.GetCharAsMorse("G"));
        }

        /// <summary>
        /// Tests a character conversion in Morse->English direction
        /// </summary>
        [TestMethod()]
        public void MorseToCharValid()
        {
            Assert.AreEqual("G", MorseCoder.GetMorseAsChar("--."));
        }

        /// <summary>
        /// Tests a character conversion in English->Morse direction
        /// </summary>
        [TestMethod()]
        public void CharToMorseInvalid()
        {
            Assert.AreEqual(string.Empty, MorseCoder.GetCharAsMorse("sdfg"));
        }

        /// <summary>
        /// Tests a character conversion in Morse->English direction
        /// </summary>
        [TestMethod()]
        public void MorseToCharInvalid()
        {
            Assert.AreEqual(string.Empty, MorseCoder.GetMorseAsChar("sdf"));
        }
    }
}