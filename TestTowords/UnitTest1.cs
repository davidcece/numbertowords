using Exercise01;
namespace TestTowords
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestGetOnes()
        {
            Assert.AreEqual(string.Empty, NumberExtension.getOnes("0"));
            Assert.AreEqual("One", NumberExtension.getOnes("1"));
        }

        [TestMethod]
        public void TestGetTens()
        {
            Assert.AreEqual(string.Empty, NumberExtension.getTens("00"));
            Assert.AreEqual("Ten", NumberExtension.getTens("10"));
            Assert.AreEqual("Twenty-Five", NumberExtension.getTens("25"));
            Assert.AreEqual("Seventy", NumberExtension.getTens("70"));
            Assert.AreEqual("Ninety-Nine", NumberExtension.getTens("99"));
        }


        [TestMethod]
        public void TestGetHundreds()
        {
            Assert.AreEqual(string.Empty, NumberExtension.getHundreds("0"));
            Assert.AreEqual("Twenty-Five", NumberExtension.getHundreds("25"));
            Assert.AreEqual("One Hundred and Five", NumberExtension.getHundreds("105"));
            Assert.AreEqual("Seven Hundred", NumberExtension.getHundreds("700"));
            Assert.AreEqual("Four Hundred and Sixty-Seven", NumberExtension.getHundreds("467"));
        }

        [TestMethod]
        public void TestNumberToWords()
        {
            Assert.AreEqual(string.Empty, NumberExtension.ConvertNumberToWords("00"));
            Assert.AreEqual("Ten", NumberExtension.ConvertNumberToWords("10"));
            Assert.AreEqual("Twenty-Five", NumberExtension.ConvertNumberToWords("25"));
            Assert.AreEqual("Seventy Million, Six Hundred and Eighty-Seven Thousand, Nine Hundred and Twenty", NumberExtension.ConvertNumberToWords("70687920"));
            Assert.AreEqual("One Hundred and Twenty Billion, One Hundred and Seventy Million, Six Hundred and Eighty-Seven Thousand, Nine Hundred and Twenty", NumberExtension.ConvertNumberToWords("120170687920"));
            Assert.AreEqual("Seven Hundred and Eighty Billion, Two Hundred", NumberExtension.ConvertNumberToWords("780000000200"));
            Assert.AreEqual("Eighteen Million", NumberExtension.ConvertNumberToWords("18000000"));
            Assert.AreEqual("One Hundred and Eighty Octillion", NumberExtension.ConvertNumberToWords("180000000000000000000000000000"));
            Assert.AreEqual("Eighteen Quintillion, Four Hundred and Fifty-Six Quadrillion, Two Trillion, Thirty-Two Billion, Eleven Million, and Seven", NumberExtension.ConvertNumberToWords("18,456,002,032,011,000,007"));
        }



    }
}