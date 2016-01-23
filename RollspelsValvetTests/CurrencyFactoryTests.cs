using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollspelsValvet;

namespace RollspelsValvetTests
{
    [TestClass()]
    public class CurrencyFactoryTests
    {
        [TestMethod()]
        public void BuildTest()
        {
            var bc = CurrencyFactory.Build(CurrencyFactory.Type.FourteenthAge);
            Assert.IsInstanceOfType(bc, typeof(CurrencyFourteenthAge));
            Console.WriteLine(bc.GetType());
        }
    }
}