using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollspelsValvet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollspelsValvet.Tests
{
    [TestClass()]
    public class CurrencyFourteenthAgeTests
    {
        [TestMethod()]
        public void AddChangesBalance()
        {
            var c = new CurrencyFourteenthAge("14");

            int currentAmount = 0;
            int adding = 123;
            int expected = 123;

            c.Add(123);

            int actual = c.Amount;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void NameIsCorrect()
        {
            var c = new CurrencyFourteenthAge("14th Age");

            string expected = "14th Age";
            string actual = c.Name;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void Subtract_Removes_Balance()
        {
            var c = new CurrencyFourteenthAge("14");

            int currentAmount = 0;
            int removing = 123;
            int expected = -123;

            c.Subtract(123);

            int actual = c.Amount;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FormatTest()
        {
            var c = new CurrencyFourteenthAge("14");

            c.Add(12345);
            string expected = "123 gm 4 sm 5 km";
            string actual = c.Format();
            Assert.AreEqual(expected, actual);

            c.Subtract(12000);
            expected = "3 gm 4 sm 5 km";
            actual = c.Format();
            Assert.AreEqual(expected, actual);

            c.Subtract(300);
            expected = "4 sm 5 km";
            actual = c.Format();
            Assert.AreEqual(expected, actual);

            c.Subtract(40);
            expected = "5 km";
            actual = c.Format();
            Assert.AreEqual(expected, actual);
        }
    }
}