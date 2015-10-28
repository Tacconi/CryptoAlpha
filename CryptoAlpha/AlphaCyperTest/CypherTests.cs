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
        public void TestCaesarEncodeABBA() // Funziona
        {
            string testo = "ABBA";
            string codice = "D";
            string expected = "DEED";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        [TestMethod]
        public void TestCaesarEncodeBCCB() // Funziona
        {
            string testo = "BCCB";
            string codice = "D";
            string expected = "EFFE";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        [TestMethod]
        public void TestCaesarDecodeDEED() // Funziona
        {
            string testo = "DEED";
            string codice = "D";
            string expected = "ABBA";
            Caesar crypt = new Caesar();
            string codifica = crypt.Decode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        [TestMethod]
        public void TestCaesarDecodeEDDS() // Funziona
        {
            string testo = "EDDS";
            string codice = "E";
            string expected = "AZZO";
            Caesar crypt = new Caesar();
            string codifica = crypt.Decode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        [TestMethod]
        public void TestVigenereEncodeABBA() // Funziona
        {
            string testo = "ABBA";
            string codice = "DFS";
            string expected = "DGTD";
            Vigenere crypt = new Vigenere();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        [TestMethod]
        public void TestVigenereDecodeDGTD() // Funziona
        {
            string testo = "DGTD";
            string codice = "DFS";
            string expected = "ABBA";
            Vigenere crypt = new Vigenere();
            string codifica = crypt.Decode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
    }
}
