using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Inheritance
{
    public class Crab
    {
        public virtual string PinchClaws()
        {
            return "clap clap";
        }
    }

    public class CoconutCrab : Crab
    {
        public override string PinchClaws()
        {
            return "CLAP CLAP";
        }
    }

    public class InheritancePractice
    {
        public static void CrabExercise()
        {
            Console.WriteLine("Call method PinchClaws on Crab Class");
            Crab crab = new Crab();
            string result = crab.PinchClaws();
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Call method PinchClaws on Coconut Crab Class");
            CoconutCrab coconutCrab = new CoconutCrab();
            result = coconutCrab.PinchClaws();
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Call method PinchClaws on Coconut Crab cast to Crab");
            CoconutCrab coconutCrab2 = new CoconutCrab();
            Crab crab2 = (Crab)coconutCrab;
            result = crab2.PinchClaws();
            Console.WriteLine(result);
            Console.WriteLine();

            try
            {
                Console.WriteLine("Call method PinchClaws on Crab cast to Coconut Crab Class");
                Crab crab3 = new Crab();
                CoconutCrab coconutCrab3 = (CoconutCrab)crab3;
                result = coconutCrab3.PinchClaws();
                Console.WriteLine(result);
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Can't cast a Crab object to a Coconut Crab object.");
            }
        }
    }
}
