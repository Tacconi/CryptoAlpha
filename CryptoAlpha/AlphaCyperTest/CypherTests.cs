using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaCypher;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Threading.Tasks;

namespace AlphaCyperTest
{
    [TestClass]
    public class Cyphertests
    {
        #region[TEST-CAESAR (SYNC)]
        #region[CAESAR - ENCODE]
        [TestMethod]
        public void TestCaesarEncodeA() // Funziona
        {
            string testo = "A";
            string codice = "D";
            string expected = "D";
            Caesar crypt = new Caesar();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
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
        #endregion
        #region[CAESAR - DECODE]
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
        #endregion
        #endregion

        #region[TEST-VIGENERE (SYNC)]
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
        #endregion

        #region[TEST-CAESAR32 (SYNC)]
        #region[CAESAR32 - ENCODE]
        [TestMethod]
        public void TestCaesar32EncodeA()
        {
            string testo = "ABBA";
            string codice = "D";
            string expected = "QVADDPH7";
            Caesar32 crypt = new Caesar32();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        #endregion
        #region[CAESAR32 - DECODE]
        [TestMethod]
        public void TestCaesar32DecodeIRCUKRA()
        {
            string testo = "QVADDPH7";
            string codice = "D";
            string expected = "ABBA";
            Caesar32 crypt = new Caesar32();
            string codifica = crypt.Decode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        #endregion

        #endregion

        #region[TEST-VIGENERE32 (SYNC)]
        #region[VIGENERE32 - ENCODE]
        [TestMethod]
        public void TestVigenere32EncodeABBA()
        {
            string testo = "ABBA";
            string codice = "DFS";
            string expected = "QWEJKPH7";
            Vigenere32 crypt = new Vigenere32();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        #endregion
        #region[VIGENERE32 - DECODE]
        [TestMethod]
        public void TestVigenere32DecodeQWEJKPH7()
        {
            string testo = "QWEJKPH7";
            string codice = "DFS";
            string expected = "ABBA";
            Vigenere32 crypt = new Vigenere32();
            string codifica = crypt.Decode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        #endregion

        #endregion

        #region[TEST-CAESAR64 (SYNC)]
        #region[CAESAR64 - ENCODE]
        [TestMethod]
        public void TestCaesar64EncodeA()
        {
            string testo = "ABBA";
            string codice = "D";
            string expected = "hUIBhQ//";
            Caesar64 crypt = new Caesar64();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        #endregion
        #region[CAESAR32 - DECODE]
        [TestMethod]
        public void TestCaesar64DecodeIRCUKRA()
        {
            string testo = "hUIBhQ//";
            string codice = "D";
            string expected = "ABBA";
            Caesar64 crypt = new Caesar64();
            string codifica = crypt.Decode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        #endregion

        #endregion

        #region[TEST-VIGENERE64 (SYNC)]
        #region[VIGENERE64 - ENCODE]
        [TestMethod]
        public void TestVigenere64EncodeABBA()
        {
            string testo = "ABBA";
            string codice = "DFS";
            string expected = "hYiVhUYS";
            Vigenere64 crypt = new Vigenere64();
            string codifica = crypt.Encode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        #endregion
        #region[VIGENERE64 - DECODE]
        [TestMethod]
        public void TestVigenere6DecodehYiVhUYS()
        {
            string testo = "hYiVhUYS";
            string codice = "DFS";
            string expected = "ABBA";
            Vigenere64 crypt = new Vigenere64();
            string codifica = crypt.Decode(testo, codice);
            Assert.AreEqual(expected, codifica);
        }
        #endregion

        #endregion

       }
}
