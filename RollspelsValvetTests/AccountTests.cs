using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollspelsValvet;

namespace RollspelsValvetTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void GetBalanceTest()
        {
            var a = new Account("Test");

            var expected = 246;
            var transaction = new Transaction(123, DateTime.Now);
            transaction.AddNote("Testar bara");

            a.AddTransaction(transaction);
            a.AddTransaction(transaction);

            var actual = a.GetBalance();
            Assert.AreEqual(expected, actual);


            transaction = new Transaction(-123, DateTime.Now);
            transaction.AddNote("Testar bara");

            a.AddTransaction(transaction);

            expected = 123;
            actual = a.GetBalance();
            Assert.AreEqual(expected, actual);

            foreach (var tr in a.Transactions)
            {
                Console.WriteLine($"{tr.Amount} - {tr.Day} - {tr.Note}");
            }
        }

        [TestMethod]
        public void AccountTest()
        {
            var a = new Account("Test");

            Assert.AreEqual(a.Name, "Test");
            Assert.AreEqual(a.GetBalance().GetType(), typeof (int));
        }
    }
}