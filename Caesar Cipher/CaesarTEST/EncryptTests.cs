using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaesarTEST
{
    [TestClass]
    public class EncryptTests
    {
        Caesar_Cipher.Caesar c = new Caesar_Cipher.Caesar();

        /// <summary>
        /// Check output for empty string
        /// </summary>
        [TestMethod]
        public void TestEncryptStringEmpty()
        {
            Assert.AreEqual(string.Empty, c.Encrypt(string.Empty, 1));
        }


        /// <summary>
        /// Check output for large positive shifts
        /// </summary>
        [TestMethod]
        public void TestEncryptLargeShift()
        {
            Assert.AreEqual("ABC", c.Encrypt("ABC", 52));
        }


        /// <summary>
        /// Check output for lower and upper cases
        /// </summary>
        [TestMethod]
        public void TestEncryptUpperLowerCase()
        {
            Assert.AreEqual("zZaA", c.Encrypt("yYzZ", 1));
        }

        /// <summary>
        /// Check output for special characters
        /// </summary>
        [TestMethod]
        public void TestEncryptSpecialChars()
        {
            Assert.AreEqual("Uijt jt b uftu # A= 3y + 4z, % $8.00", 
                c.Encrypt("This is a test # Z= 3x + 4y, % $8.00", 53));
        }


    }
}
