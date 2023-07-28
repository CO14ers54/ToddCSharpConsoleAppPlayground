using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.AsyncAndAwait
{
    /*
        In the code given below, Method1 and Method2 are not dependent on each other and we are calling from the RunExample1 method. When run, we can clearly see Method1 and Method2
        are not waiting for each other.
    */
    public class Example1
    {
        private static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1");
                    // Do Something
                    Task.Delay(100).Wait();
                }
            });
        }

        private static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method 2");
                // Do Something
                Task.Delay(25).Wait();
            }
        }

        public static void RunExample1()
        {
            Method1();
            Method2();
        }
    }
}
