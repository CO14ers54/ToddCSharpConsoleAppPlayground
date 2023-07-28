using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Decorator
{
    public class DecoratorPatternExample
    {
        public static void OrderPizzas()
        {
            double totalPrice = 0.00;

            // Order a Pepperoni Pizza
            Console.WriteLine($"Ordering a Pepperoni Pizza!!!");
            Pizza pizza = new Pepperoni();
            Console.WriteLine($"Description: {pizza.GetDescription()} and Pizza Price: {string.Format("{0:C}", pizza.GetPizzaPrice())}");
            totalPrice += pizza.GetPizzaPrice();
            Console.WriteLine("");

            // Order a Double Cheese Pepperoni Pizza
            Console.WriteLine($"Ordering a Double Cheese Pepperoni Pizza!!!");
            pizza = new DoubleCheesePepperoni();
            Console.WriteLine($"Description: {pizza.GetDescription()} and Pizza Price: {string.Format("{0:C}", pizza.GetPizzaPrice())}.");
            totalPrice += pizza.GetPizzaPrice();
            Console.WriteLine("");

            // Order a Chicago Seven Pizza
            Console.WriteLine($"Ordering a Chicago Seven Pizza!!!");
            pizza = new ChicagoSeven();
            Console.WriteLine($"Description: {pizza.GetDescription()} and Pizza Price: {string.Format("{0:C}",pizza.GetPizzaPrice())}.");
            totalPrice += pizza.GetPizzaPrice();
            Console.WriteLine("");

            // Order a Margherita Pizza
            Console.WriteLine($"Ordering a Margherita Pizza!!!");
            pizza = new Margherita();
            Console.WriteLine($"Description: {pizza.GetDescription()} and Pizza Price: {string.Format("{0:C}",pizza.GetPizzaPrice())}.");
            totalPrice += pizza.GetPizzaPrice();
            Console.WriteLine("");

            // Order a Pueblo, Colorado Pizza
            Console.WriteLine($"Ordering a Pueblo, CO pizza!!!");
            pizza = new PuebloCo();
            Console.WriteLine($"Description: {pizza.GetDescription()} and Pizza Price: {string.Format("{0:C}", pizza.GetPizzaPrice())}.");
            totalPrice += pizza.GetPizzaPrice();
            Console.WriteLine("");

            // Order a Santa Maria Cowboy Pizza
            Console.WriteLine($"Ordering a Santa Maria Cowboy pizza!!!");
            pizza = new SantaMariaCowboy();
            Console.WriteLine($"Description: {pizza.GetDescription()} and Pizza Price: {string.Format("{0:C}", pizza.GetPizzaPrice())}.");
            totalPrice += pizza.GetPizzaPrice();
            Console.WriteLine("");

            // Print out the order total sans tax
            Console.WriteLine($"Total Price (sans tax): {string.Format("{0:C}", totalPrice)}.");
        }
    }
}
