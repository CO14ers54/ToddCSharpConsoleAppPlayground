using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Decorator
{
    public abstract class Pizza
    {
        protected string m_description = "Unknown Pizza";
        protected double m_totalToppingsPrice = 0.00;
        protected const double m_basePizzaPrice = 10.00; // Includes Large Crust, Choice of any Tomato-based sauce and grated mozzarella

        public string GetDescription()
        {
            return m_description;
        }

        public double GetPizzaPrice()
        {
            return m_basePizzaPrice + m_totalToppingsPrice;
        }

        // All pizza related classes will inherit this class
        public void AddToppingPrice(double toppingPrice)
        {
            m_totalToppingsPrice += toppingPrice;
        }

        protected abstract void Crust();
        protected abstract void AddToppings();
    }
}
