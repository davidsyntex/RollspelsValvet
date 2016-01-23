using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollspelsValvet;

namespace RollspelsValvetTests
{
    [TestClass()]
    public class AccountFactoryTests
    {
        [TestMethod()]
        public void BuildTest()
        {
            var af = AccountFactory.Build(AccountFactory.Type.Bank, "TestKonto");
            Assert.IsInstanceOfType(af, typeof(Account));
            Console.WriteLine(af.GetType());
        }
    }
}