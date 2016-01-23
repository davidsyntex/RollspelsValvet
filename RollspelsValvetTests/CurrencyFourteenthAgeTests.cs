using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollspelsValvet;

namespace RollspelsValvetTests
{
    [TestClass()]
    public class CurrencyFourteenthAgeTests
    {
        [TestMethod()]
        public void FormatTest()
        {
            string expected = "123 gm 4 sm 5 km";
            string actual = CurrencyFourteenthAge.Format(12345);
            Assert.AreEqual(expected, actual);

            expected = "3 gm 4 sm 5 km";
            actual = CurrencyFourteenthAge.Format(345);
            Assert.AreEqual(expected, actual);

            expected = "4 sm 5 km";
            actual = CurrencyFourteenthAge.Format(45);
            Assert.AreEqual(expected, actual);

            expected = "5 km";
            actual = CurrencyFourteenthAge.Format(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToGoldRoundedDownTest()
        {
            var amount = 12345;
            var expected = 123;
            var actual = CurrencyFourteenthAge.ConvertToGoldRoundedDown(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToGoldTest()
        {
            var amount = 12345;
            var expected = 123.45;
            var actual = CurrencyFourteenthAge.ConvertToGold(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToSilverRoundedDownTest()
        {
            var amount = 12345;
            var expected = 1234;
            var actual = CurrencyFourteenthAge.ConvertToSilverRoundedDown(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToSilverTest()
        {
            var amount = 12345;
            var expected = 1234.5;
            var actual = CurrencyFourteenthAge.ConvertToSilver(amount);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CurrencyFourteenthAgeTest()
        {
            Assert.Fail();
        }
    }
}