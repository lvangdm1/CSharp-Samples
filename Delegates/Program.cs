using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // here is delegate type below.
    public delegate string MyDelegate(int arg1, int arg2);
    class Program
    {
        // delegate static class functions below.
        static string func1(int a, int b)
        {
            return (a + b).ToString();
        }
        static string func2(int a, int b)
        {
            return (a * b).ToString();
        }


        static void Main(string[] args)
        {
            // Delegate can be called like a method, but without the "new" keyword.
            MyDelegate f = func1;
            Console.WriteLine("The number is: " + f(10, 20));

            // Can also be switched dynamically at runtime like below.
            f = func2;
            Console.WriteLine("The number is: " + f(10, 20));

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
