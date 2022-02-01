using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.AreEqual("--.", MorseCoder.GetCharAsMorse('G'));
        }

        /// <summary>
        /// Tests a lowercase character conversion in English->Morse direction
        /// </summary>
        [TestMethod()]
        public void CharToMorseValidLowercase()
        {
            Assert.AreEqual("--.", MorseCoder.GetCharAsMorse('g'));
        }

        /// <summary>
        /// Tests a character conversion in Morse->English direction
        /// </summary>
        [TestMethod()]
        public void MorseToCharValid()
        {
            Assert.AreEqual('G', MorseCoder.GetMorseAsChar("--."));
        }

        /// <summary>
        /// Tests an invalid character conversion in English->Morse direction
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void CharToMorseInvalid()
        {
            MorseCoder.GetCharAsMorse('&');
        }

        /// <summary>
        /// Tests an invalid character conversion in Morse->English direction
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void MorseToCharInvalid()
        {
             MorseCoder.GetMorseAsChar("&");
        }
    }
}