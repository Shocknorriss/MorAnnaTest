using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSystemConverter_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Greater_Than_ThreeThousand_Throws_IndexOutOfRangeException_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(3001);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Less_Than_One_Throws_IndexOutOfRangeException_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(-1);
        }
    }
}
