using Microsoft.VisualStudio.TestTools.UnitTesting;
using Intermediate6;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate6.Tests
{
    [TestClass()]
    public class MorseDecoderTests
    {
        [TestMethod()]
        public void DecodeString1()
        {
            Assert.AreEqual("SOS", new MorseDecoder().DecodeString("... --- ..."));
        }
        [TestMethod()]
        public void DecodeString2()
        {
            Assert.AreEqual("TEST 2", new MorseDecoder().DecodeString("- . ... -   ..---"));
        }
    }
}