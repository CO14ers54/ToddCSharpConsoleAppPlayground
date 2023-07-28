using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ToddCSharpConsoleAppPlayground.Patterns.Decorator.ConcreteToppingClasses;

namespace ToddCSharpConsoleAppPlayground.Patterns.Decorator
{
    public sealed class Pepperoni : Pizza
    {
        public Pepperoni()
        {
            m_description = "Pepperoni";
            Crust();
            AddToppings();
        }

        protected override void Crust()
        {
            Console.WriteLine("Prepared on our House Made Hand-Tossed crust");
        }

        protected override void AddToppings()
        {
            ClassicRedPizzaSauce sauce = new ClassicRedPizzaSauce(this);
            Console.WriteLine($"Adding {sauce.GetDescription()} for a Price of {string.Format("{0:C}", sauce.GetToppingPrice())}...");
            ConcreteToppingClasses.Pepperoni pepperoni = new ConcreteToppingClasses.Pepperoni(this);
            Console.WriteLine($"Adding {pepperoni.GetDescription()} for a Price of {string.Format("{0:C}", pepperoni.GetToppingPrice())}...");
            GratedMozzarella mozza = new GratedMozzarella(this);
            Console.WriteLine($"Adding {mozza.GetDescription()} for a Price of {string.Format("{0:C}", mozza.GetToppingPrice())}...");
        }
    }

    public sealed class DoubleCheesePepperoni : Pizza
    {
        public DoubleCheesePepperoni()
        {
            m_description = "Double Cheese Pepperoni";
            Crust();
            AddToppings();
        }

        protected override void Crust()
        {
            Console.WriteLine("Prepared on our House Made Hand-Tossed crust");
        }

        protected override void AddToppings()
        {
            ClassicRedPizzaSauce sauce = new ClassicRedPizzaSauce(this);
            Console.WriteLine($"Adding {sauce.GetDescription()} for a Price of {string.Format("{0:C}", sauce.GetToppingPrice())}...");
            ConcreteToppingClasses.Pepperoni pepperoni = new ConcreteToppingClasses.Pepperoni(this);
            Console.WriteLine($"Adding {pepperoni.GetDescription()} for a Price of {string.Format("{0:C}", pepperoni.GetToppingPrice())}...");
            DoubleGratedMozzarella mozza = new DoubleGratedMozzarella(this);
            Console.WriteLine($"Adding {mozza.GetDescription()} for a Price of {string.Format("{0:C}", mozza.GetToppingPrice())}...");
        }
    }

    public sealed class ChicagoSeven : Pizza
    {
        public ChicagoSeven()
        {
            m_description = "Chicago Seven";
            Crust();
            AddToppings();
        }

        protected override void Crust()
        {
            Console.WriteLine("Prepared on our House Made Hand-Tossed crust");
        }

        protected override void AddToppings()
        {
            ClassicRedPizzaSauce sauce = new ClassicRedPizzaSauce(this);
            Console.WriteLine($"Adding {sauce.GetDescription()} for a Price of {string.Format("{0:C}",sauce.GetToppingPrice())}...");
            ConcreteToppingClasses.Pepperoni pepperoni = new ConcreteToppingClasses.Pepperoni(this);
            Console.WriteLine($"Adding {pepperoni.GetDescription()} for a Price of {string.Format("{0:C}",pepperoni.GetToppingPrice())}...");
            HotItalianSausage sausage = new HotItalianSausage(this);
            Console.WriteLine($"Adding {sausage.GetDescription()} for a Price of {string.Format("{0:C}",sausage.GetToppingPrice())}...");
            GreenPepper greenPepper = new GreenPepper(this);
            Console.WriteLine($"Adding {greenPepper.GetDescription()} for a Price of {string.Format("{0:C}",greenPepper.GetToppingPrice())}...");
            BlackOlives blackOlives = new BlackOlives(this);
            Console.WriteLine($"Adding {blackOlives.GetDescription()} for a Price of {string.Format("{0:C}",blackOlives.GetToppingPrice())}...");
            FreshMushrooms mushrooms = new FreshMushrooms(this);
            Console.WriteLine($"Adding {mushrooms.GetDescription()} for a Price of {string.Format("{0:C}",mushrooms.GetToppingPrice())}...");
            GratedMozzarella mozza = new GratedMozzarella(this);
            Console.WriteLine($"Adding {mozza.GetDescription()} for a Price of {string.Format("{0:C}", mozza.GetToppingPrice())}...");
        }
    }

    public sealed class PuebloCo : Pizza
    {
        public PuebloCo()
        {
            m_description = "Pueblo Colorado";
            Crust();
            AddToppings();
        }

        protected override void Crust()
        {
            Console.WriteLine("Prepared on our House Made Hand-Tossed crust");
        }

        protected override void AddToppings()
        {
            RefriedBeanSauce sauce = new RefriedBeanSauce(this);
            Console.WriteLine($"Adding {sauce.GetDescription()} for a Price of {string.Format("{0:C}",sauce.GetToppingPrice())}...");
            Chicken chicken = new Chicken(this);
            Console.WriteLine($"Adding {chicken.GetDescription()} for a Price of {string.Format("{0:C}", chicken.GetToppingPrice())}...");
            PuebloGreenChili greenChili = new PuebloGreenChili(this);
            Console.WriteLine($"Adding {greenChili.GetDescription()} for a Price of {string.Format("{0:C}", greenChili.GetToppingPrice())}...");
            FreshTomato tomato = new FreshTomato(this);
            Console.WriteLine($"Adding {tomato.GetDescription()} for a Price of {string.Format("{0:C}", tomato.GetToppingPrice())}...");
            Jalapenos jalapenos = new Jalapenos(this);
            Console.WriteLine($"Adding {jalapenos.GetDescription()} for a Price of {string.Format("{0:C}", jalapenos.GetToppingPrice())}...");
            YellowOnions onions = new YellowOnions(this);
            Console.WriteLine($"Adding {onions.GetDescription()} for a Price of {string.Format("{0:C}", onions.GetToppingPrice())}...");
            GratedMozzarella mozza = new GratedMozzarella(this);
            Console.WriteLine($"Adding {mozza.GetDescription()} for a Price of {string.Format("{0:C}", mozza.GetToppingPrice())}...");
            SharpCheddar sharpCheddar = new SharpCheddar(this);
            Console.WriteLine($"Adding {sharpCheddar.GetDescription()} for a Price of {string.Format("{0:C}", sharpCheddar.GetToppingPrice())}...");
        }
    }

    public sealed class SantaMariaCowboy : Pizza
    {
        public SantaMariaCowboy()
        {
            m_description = "Santa Maria Cowboy";
            Crust();
            AddToppings();
        }

        protected override void Crust()
        {
            Console.WriteLine("Prepared on our House Made Hand-Tossed crust");
        }

        protected override void AddToppings()
        {
            SeasonedPinquitoBeanSauce sauce = new SeasonedPinquitoBeanSauce(this);
            Console.WriteLine($"Adding {sauce.GetDescription()} for a Price of {string.Format("{0:C}",sauce.GetToppingPrice())}...");
            TriTip triTip = new TriTip(this);
            Console.WriteLine($"Adding {triTip.GetDescription()} for a Price of {string.Format("{0:C}", triTip.GetToppingPrice())}...");
            RedOnions onions = new RedOnions(this);
            Console.WriteLine($"Adding {onions.GetDescription()} for a Price of {string.Format("{0:C}", onions.GetToppingPrice())}...");
            FreshMushrooms mushrooms = new FreshMushrooms(this);
            Console.WriteLine($"Adding {mushrooms.GetDescription()} for a Price of {string.Format("{0:C}",mushrooms.GetToppingPrice())}...");
            DoubleGratedMozzarella mozza = new DoubleGratedMozzarella(this);
            Console.WriteLine($"Adding {mozza.GetDescription()} for a Price of {string.Format("{0:C}", mozza.GetToppingPrice())}...");
        }
    }

    public sealed class Margherita : Pizza
    {
        public Margherita()
        {
            m_description = "Margherita";
            Crust();
            AddToppings();
        }

        protected override void Crust()
        {
            Console.WriteLine("Prepared on our House Made Hand-Tossed crust");
        }

        protected override void AddToppings()
        {
            BasicTomatoSauce sauce = new BasicTomatoSauce(this);
            Console.WriteLine($"Adding {sauce.GetDescription()} for a Price of {string.Format("{0:C}",sauce.GetToppingPrice())}...");
            SlicedWholeMozzarella wholeMozza = new SlicedWholeMozzarella(this);
            Console.WriteLine($"Adding {wholeMozza.GetDescription()} for a Price of {string.Format("{0:C}",wholeMozza.GetToppingPrice())}...");
            FreshBasil freshBasil = new FreshBasil(this);
            Console.WriteLine($"Adding {freshBasil.GetDescription()} for a Price of {string.Format("{0:C}",freshBasil.GetToppingPrice())}...");
            OliveOil evoo = new OliveOil(this);
            Console.WriteLine($"Adding {evoo.GetDescription()} for a Price of {string.Format("{0:C}",evoo.GetToppingPrice())}...");
        }
    }
}
