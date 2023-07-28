using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ToddCSharpConsoleAppPlayground.Delegates.DelegatePractice;

namespace ToddCSharpConsoleAppPlayground.Delegates
{
    public class XX
    {
        public event MySCDelegate MySCEvent;
        public event MyMCDelegate MyMCEvent;

        public void RaiseSCEvent(int a)
        {
            MySCEvent(a);
            Console.WriteLine("SC Event Raised");
        }

        public void RaiseMCEvent(int a, int b)
        {
            MyMCEvent(a, b);
            Console.WriteLine("MC Event Raised");
        }

        public void Display(int x)
        {
            Console.WriteLine($"Display Method {x}.");
        }

        public int Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"Add Method {sum}");
            return sum;
        }

        public int Subtract(int x, int y)
        {
            int difference = x - y;
            Console.WriteLine($"Subtract Method {difference}");
            return difference;
        }

        public int Multiply(int x, int y)
        {
            int product = x * y;
            Console.WriteLine($"MultiplyMethod {product}");
            return product;
        }
    }
}
