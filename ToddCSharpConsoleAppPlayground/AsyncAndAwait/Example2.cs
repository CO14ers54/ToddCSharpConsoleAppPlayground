using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.AsyncAndAwait
{
    /*
        In this example, Method1 is returning the total length as an integer value and we are passing a parameter as a length in a Method3, which is coming from Method1.

        Here, we have to use await keyword before passing a parameter in Method3 and for it, we have to use the async keyword from the calling method. 
    */



    public class Example2
    {
        public static async Task<int> Method1()
        {
            int count = 0;
            Task t = Task.Run(() =>
            {
                for (int i = 0;i < 100; i++)
                {
                    Console.WriteLine("Method 1");
                    count++;
                }
            });
            await (t);

            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        public static async Task RunExercise2()
        {
            Method2();
            int count = await Method1();
            Method3(count);
        }
    }
}
