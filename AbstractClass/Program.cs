using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        // interesting to remember { Width = 5} 
        static void Main(string[] args)
        {
            var s1 = new Square() { Width = 5 };
        // can't do this: Console.WriteLine(s1.Display());
            s1.Display();

            var s2 = new Square() { Width = 5 };
            Console.WriteLine(s2.GetArea());

            var s3 = new Square2() { Width = 5 };
            Console.WriteLine(s3.GetArea());

        }
    }
}
