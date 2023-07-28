using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.TestDomeExercises
{
    public class TwoSumExercise
    {
        public static Tuple<int, int> FindTwoSum(List<int> list, int sum)
        {
            int index = 0;
            var dict = list.ToDictionary(item => index++);
            Tuple<int, int> indices = null;

            KeyValuePair<int, int> kvp = dict.ElementAt(0);
            int start = 1;
            for( int i = 1; i < dict.Count; i++)
            {


                if (kvp.Value + dict.ElementAt(i).Value == sum)
                {
                    indices = Tuple.Create(kvp.Key, dict.ElementAt(i).Key);
                    break;
                }

                if (i == dict.Count - 1)
                {
                    dict.Remove(kvp.Key);
                    start += 1;
                }
            }

            return indices;
        }

        public static void RunTwoSumExercise()
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Console.WriteLine(indices.Item1 + " " + indices.Item2);
            }
            else
                Console.WriteLine("No two numbers in the array when added together totaled 10");
        }
    }
}
