using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Arrays
{
    public class ArrayPractice
    {
        /// <summary>
        /// Implement the UniqueNames method. When passed two arrays of names, 
        /// it will return an array containing the names that appear in either or both arrays. The returned array should have no duplicates.
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            string[] tempNamesArray = names1;
            foreach(string name in names2)
            {
                Array.Resize<string>(ref tempNamesArray, tempNamesArray.Length + 1);
                tempNamesArray[tempNamesArray.Length - 1] = name;
            }

            HashSet<string> uniqueNamesSet = new HashSet<string>();
            foreach (string name in tempNamesArray)
            {
                bool added = false;
                added = uniqueNamesSet.Add(name);
                if (added)
                    Console.WriteLine($"{name} was added to the unique names list");
                else
                    Console.WriteLine($"{name} was already in the unique names list and therefore not added");

            }

            return uniqueNamesSet.ToArray<string>();
        }

        public static string [] RunUniqueNamesExercise()
        {
            Console.WriteLine("Array Practice");
            Console.WriteLine();
            string[] uniqueNames;
            uniqueNames = UniqueNames(new string[] { "Ava", "Emma", "Olivia" }, new string[] { "Olivia", "Sophia", "Emma" });
            Console.WriteLine();
            return uniqueNames;
        }
    }
}
