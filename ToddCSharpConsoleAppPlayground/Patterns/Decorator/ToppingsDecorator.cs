using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Decorator
{
    public abstract class ToppingsDecorator
    {
        protected double m_toppingPrice; 
        public abstract string GetDescription();

        public double GetToppingPrice()
        {
            return m_toppingPrice;
        }
    }
}
