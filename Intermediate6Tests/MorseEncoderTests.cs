using Microsoft.VisualStudio.TestTools.UnitTesting;
using Intermediate6;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate6.Tests
{
    [TestClass()]
    public class MorseEncoderTests
    {
        [TestMethod()]
        public void EncodeString1()
        {
            Assert.AreEqual("... --- ...", new MorseEncoder().EncodeString("SOS"));
        }
        [TestMethod()]
        public void EncodeString2()
        {
            Assert.AreEqual("- . ... -   ..---", new MorseEncoder().EncodeString("Test 2"));
        }
    }
}