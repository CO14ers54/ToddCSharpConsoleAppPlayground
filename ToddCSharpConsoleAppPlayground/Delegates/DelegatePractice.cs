using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Delegates
{
    public class DelegatePractice
    {
        public delegate void MyAnonDelegate(string firstName);
        public delegate void MySCDelegate(int a);
        public delegate int MyMCDelegate(int a, int b);

        /// <summary>
        /// 1.  What is a delegate in C#?
        /// 1.  Why do we need delegates in C#?
        /// 3.  What are the benefits of delegates in C#?
        /// 4.  What are the different types of delegates in C#?
        /// 5.  How are delegates related to events in C#?
        /// 6.  What are singlecase and nulticase delegates in C#?
        /// 7.  What is an anonymous delegate in C#?
        /// 8.  C# delegate code examples.
        /// 
        /// Source:  https://www.c-sharpcorner.com/UploadFile/puranindia/C-Sharp-net-delegates-and-events/
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// 
        public static void RunDelegatePractice()
        {
            XX obj = new XX();
            Console.WriteLine("C# Delegate Practice");
            Console.WriteLine("");

            Console.WriteLine("Anonymous Delegate Practice");
            Console.WriteLine("");

            string fromColorado = "from Colorado";
            MyAnonDelegate myAnonDelegate = delegate (string firstName)
            {
                Console.WriteLine($"I am {firstName}, a mountain man {fromColorado}");
            };

            myAnonDelegate("Todd");

            Console.WriteLine("");
            Console.WriteLine("Singlecast Delegate Practice");
            Console.WriteLine("");

            // Create a Custom Singlecast delegate and event
            obj.MySCEvent += new MySCDelegate(obj.Display);
            // Raise SC event
            obj.RaiseSCEvent(20);

            Console.WriteLine("");
            Console.WriteLine("Multicast Delegate Practice");
            Console.WriteLine("");

            // Create a Custom Multicase delegate and event
            obj.MyMCEvent += new MyMCDelegate(obj.Add);
            obj.MyMCEvent += new MyMCDelegate(obj.Subtract);
            obj.MyMCEvent += new MyMCDelegate(obj.Multiply);
            // Raise SC Event
            obj.RaiseMCEvent(10, 20);

            Console.WriteLine("");
            Console.WriteLine("End C# Delegate Practice");
        }
    }
}
