using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinarySearch2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dinners = {"Pasta",
                              "Apple Pie",
                              "Tuna Melt",
                              "Mushroom Omelet",
                              "Duck",
                              "Eggplant"};

            WriteLine();
            WriteLine("\nContent of array:");
            WriteLine("------------------");
            foreach (string dinner in dinners)
            {
                WriteLine(dinner);
            }

            WriteLine("\nContent after Sort:");
            WriteLine("------------------");
            Array.Sort(dinners);

            foreach (string dinner in dinners)
            {
                WriteLine(dinner);
            }

            WriteLine("\nBinarySearch for 'Beet Salad':");
            int index = Array.BinarySearch(dinners, "Beet Salad");
            DisplayWhere(dinners, index);

            WriteLine("\nBinarySearch for 'Tuna Melt':");
            index = Array.BinarySearch(dinners, "Tuna Melt");
            DisplayWhere(dinners, index);
        }

        private static void DisplayWhere<T>(T[] array, int index)
        {
            if (index < 0)
            {
                index = ~index;

                Write("Not found. Sorts between: ");

                if (index == 0)
                    Write("beginning of array and ");
                else
                    Write("{0} and ", array[index - 1]);

                if (index == array.Length)
                    WriteLine("end of array.");
                else
                    WriteLine("{0}.", array[index]);
            }
            else
            {
                WriteLine("Found at index {0}.", index);
            }
        }
    }
}