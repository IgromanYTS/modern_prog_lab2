using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab2.Tests
{
    [TestClass]
    public class sum2sum2returned4
    {
        [TestMethod]
        public void StrategyAdd_sum2and2_returned4()
        {
            IStrategy strategy = new StrategyAdd();
            int result = strategy.execute(2, 2);
            Assert.AreEqual(4, result);

        }
    }
}
