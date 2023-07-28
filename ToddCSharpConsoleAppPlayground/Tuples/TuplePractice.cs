using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Tuples
{
    public class QuadradicEquation
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }


        public Tuple<double, double> GetRoots()
        {
            double x1 = 0;
            double x2 = 0;

            x1 = (-B + Math.Sqrt((B*B) - (4 * A * C))) / (2 * A);
            x2 = (-B - Math.Sqrt((B*B) - (4 * A * C))) / (2 * A);

            Tuple<double, double> roots;

            if (x1 == x2)
                roots = new Tuple<double, double>(x1, x1);
            else
                roots = new Tuple<double, double>(x1, x2);

            return roots;
        }
    }
    /// <summary>
    /// The Tuple<T> class was introduced in .NET Framework 4.0. A tuple is a data structure that contains a sequence of elements of different data types
    /// </summary>
    public class TuplePractice
    {

        public static void RunTuplePractice()
        {
            QuadradicEquation qe;
            Tuple<double, double> roots;
            Console.WriteLine("Tuple Practice:  Quadradic Equation");
            Console.WriteLine();

            // Quadradic Equation
            Console.WriteLine("4x^2 - 8x - 6 = 0");
            qe = new QuadradicEquation { A = 4, B = 8, C = -6 };
            roots = qe.GetRoots();
            Console.WriteLine($"Roots: ({roots.Item1},{roots.Item2})");
            Console.WriteLine();

            Console.WriteLine("2x^2 + 10x + 8 = 0");
            qe.A = 2;
            qe.B = 10;
            qe.C = 8;
            roots = qe.GetRoots();
            Console.WriteLine($"Roots: ({roots.Item1},{roots.Item2})");
            Console.WriteLine();

            Console.WriteLine("10x^2 - 14x - 3 = 0");
            qe.A = 10;
            qe.B = -14;
            qe.C = -3;
            roots = qe.GetRoots();
            Console.WriteLine($"Roots: ({roots.Item1},{roots.Item2})");
            Console.WriteLine();

            Console.WriteLine("x^2 + 2x - 2 = 0");
            qe.A = 1;
            qe.B = 0;
            qe.C = 0;
            roots = qe.GetRoots();
            Console.WriteLine($"Roots: ({roots.Item1},{roots.Item2})");
            Console.WriteLine();

        }
    }
}
