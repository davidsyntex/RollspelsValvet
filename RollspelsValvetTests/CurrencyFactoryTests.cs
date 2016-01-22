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
    public class CurrencyFactoryTests
    {
        [TestMethod()]
        public void BuildCurrencyTest()
        {
            var bc = CurrencyFactory.BuildCurrency(CurrencyFactory.Type.FourteenthAge);
            Assert.IsInstanceOfType(bc, typeof (CurrencyFourteenthAge));
            Console.WriteLine(bc.GetType());
        }
    }
}