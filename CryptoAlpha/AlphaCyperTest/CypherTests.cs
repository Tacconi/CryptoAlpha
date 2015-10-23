using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace AlphaCyperTest
{
    [TestClass]
    public class Cyphertests
    {
        [TestMethod]
        public void TestCaesarEncodeABBA()
        {
            string testo = "ABBA";
            string codice = "D";
            string expected = "DEED";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        [TestMethod]
        public void TestCaesarEncodeBCCB()
        {
            string testo = "BCCB";
            string codice = "D";
            string expected = "EFFE";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }

        [TestMethod]
        public void TestCaesarDecodeEFFE()
        {
            string testo = "DEED";
            string codice = "D";
            string expected = "ABBA";
            Caesar crypt = new Caesar();
            string codifica = crypt.Decode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }

        [TestMethod]
        public void TestCaesarDecodeEDDS()
        {
            string testo = "EDDS";
            string codice = "E";
            string expected = "AZZO";
            Caesar crypt = new Caesar();
            string codifica = crypt.Decode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
    }
}
