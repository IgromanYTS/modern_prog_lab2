using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Context
    {
        private IStrategy strategy;
        public void setStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public int executeStrategy(int a, int b)
        {
            return strategy.execute(a, b);
        }

    }
}
