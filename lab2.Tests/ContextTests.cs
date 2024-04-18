using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab2.Tests
{
    [TestClass]
    public class ContexttTests
    {
        [TestMethod]
        public void contextest() 
        {
            Context context = new Context();
            IStrategy strategy = new StrategyAdd();

            int first = 5;
            int second = 3;
            int expected = 8;
            context.setStrategy(strategy);
            int result = context.executeStrategy(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
