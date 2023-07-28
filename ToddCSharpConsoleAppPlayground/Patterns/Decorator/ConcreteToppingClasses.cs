using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Decorator
{
    public class ConcreteToppingClasses
    {
        public class ClassicRedPizzaSauce : ToppingsDecorator
        {
            private Pizza m_pizza;

            public ClassicRedPizzaSauce(Pizza pizza)
            {
                m_toppingPrice = 0.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Signature House Made Tomato and Herb Classic Red Pizza Sauce");
            }
        }

        public class BasicTomatoSauce : ToppingsDecorator
        {
            private Pizza m_pizza;

            public BasicTomatoSauce(Pizza pizza)
            {
                m_toppingPrice = 0.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Pureed Tomatoes, Olive Oil, Ground Black Pepper, Thinly sliced garlic Sauce");
            }
        }

        public class SeasonedPinquitoBeanSauce : ToppingsDecorator
        {
            private Pizza m_pizza;

            public SeasonedPinquitoBeanSauce(Pizza pizza)
            {
                m_toppingPrice = 4.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("House-Made, Flavorful Pinquito Bean Sauce inspired by the Santa Maria BBQ");
            }
        }

        public class RefriedBeanSauce : ToppingsDecorator
        {
            private Pizza m_pizza;

            public RefriedBeanSauce(Pizza pizza)
            {
                m_toppingPrice = 3.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Spicy Refried Bean based Sauce");
            }
        }

        public class GratedMozzarella : ToppingsDecorator
        {
            private Pizza m_pizza;

            public GratedMozzarella(Pizza pizza)
            {
                m_toppingPrice = 0.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Grated, Made fresh Daily, Grated Mozzarella");
            }
        }

        public class DoubleGratedMozzarella : ToppingsDecorator
        {
            private Pizza m_pizza;

            public DoubleGratedMozzarella(Pizza pizza)
            {
                m_toppingPrice = 2.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Extra Serving of Grated, Made fresh Daily, Grated Mozzarella");
            }
        }

        public class SlicedWholeMozzarella : ToppingsDecorator
        {
            private Pizza m_pizza;

            public SlicedWholeMozzarella(Pizza pizza)
            {
                m_toppingPrice = 2.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Whole, Made fresh Daily Mozzarella sliced");
            }
        }

        public class SharpCheddar : ToppingsDecorator
        {
            private Pizza m_pizza;

            public SharpCheddar(Pizza pizza)
            {
                m_toppingPrice = 0.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Grated, High Quality, Sharp Cheddar Cheese");
            }
        }

        public class OliveOil : ToppingsDecorator
        {
            private Pizza m_pizza;

            public OliveOil(Pizza pizza)
            {
                m_toppingPrice = 0.75;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("High Quality, Extra Virgin Olive Oil");
            }
        }

        public class FreshTomato : ToppingsDecorator
        {
            private Pizza m_pizza;

            public FreshTomato(Pizza pizza)
            {
                m_toppingPrice = 1.75;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Fresh, Diced Tomatoes");
            }
        }

        public class FreshBasil : ToppingsDecorator
        {
            private Pizza m_pizza;

            public FreshBasil(Pizza pizza)
            {
                m_toppingPrice = 1.75;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Fresh, Julienned strips of Basil");
            }
        }

        public class FreshMushrooms : ToppingsDecorator
        {
            private Pizza m_pizza;

            public FreshMushrooms(Pizza pizza)
            {
                m_toppingPrice = 1.75;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Fresh, Sliced Mushrooms.  There is a fungus among us!");
            }
        }

        public class BlackOlives : ToppingsDecorator
        {
            private Pizza m_pizza;

            public BlackOlives(Pizza pizza)
            {
                m_toppingPrice = 1.75;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Pitted and Sliced Fresh Black Olives.");
            }
        }

        public class RedOnions : ToppingsDecorator
        {
            private Pizza m_pizza;

            public RedOnions(Pizza pizza)
            {
                m_toppingPrice = 1.75;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Fresh, Sliced Red Onions.");
            }
        }

        public class YellowOnions : ToppingsDecorator
        {
            private Pizza m_pizza;

            public YellowOnions(Pizza pizza)
            {
                m_toppingPrice = 1.75;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Fresh, Sliced Yellow Onions.");
            }
        }

        public class GreenPepper : ToppingsDecorator
        {
            private Pizza m_pizza;

            public GreenPepper(Pizza pizza)
            {
                m_toppingPrice = 1.75;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Fresh, Sliced Green Pepper.");
            }
        }

        public class PuebloGreenChili : ToppingsDecorator
        {
            private Pizza m_pizza;

            public PuebloGreenChili(Pizza pizza)
            {
                m_toppingPrice = 2.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Roasted, Sliced Medium Green Chilies from Pueblo Colorado.");
            }
        }

        public class PicoDeGallo : ToppingsDecorator
        {
            private Pizza m_pizza;

            public PicoDeGallo(Pizza pizza)
            {
                m_toppingPrice = 2.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Flavorful, Fresh Pico de Gallo.");
            }
        }

        public class Jalapenos : ToppingsDecorator
        {
            private Pizza m_pizza;

            public Jalapenos(Pizza pizza)
            {
                m_toppingPrice = 1.75;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Always Fresh, Sliced Jalapenos.");
            }
        }

        public class HotItalianSausage : ToppingsDecorator
        {
            private Pizza m_pizza;

            public HotItalianSausage(Pizza pizza)
            {
                m_toppingPrice = 2.50;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Authentic, Imported, Italian, Spicy Sausage");
            }
        }

        public class Pepperoni : ToppingsDecorator
        {
            private Pizza m_pizza;

            public Pepperoni(Pizza pizza)
            {
                m_toppingPrice = 2.50;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Authentic, Imported, Italian, Sliced Pepperoni");
            }
        }

        public class Chicken : ToppingsDecorator
        {
            private Pizza m_pizza;

            public Chicken(Pizza pizza)
            {
                m_toppingPrice = 2.50;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Season, Rotisserie Chicken");
            }
        }

        public class TriTip : ToppingsDecorator
        {
            private Pizza m_pizza;

            public TriTip(Pizza pizza)
            {
                m_toppingPrice = 5.00;
                m_pizza = pizza;
                m_pizza.AddToppingPrice(m_toppingPrice);
            }

            public override string GetDescription()
            {
                return ("Flavorul TriTip cooked on the grill Santa Maria Barbeque Style");
            }
        }
    }
}
