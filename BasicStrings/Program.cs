using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStrings
{
    class Program
    {


        static void Main(string[] args)
        {
            var s1 = "Hello";
            var results = s1.ToUpper();

            Console.WriteLine(results);

            Char c1 = '\u2708';
            Console.WriteLine(c1);


            var c = new CharArray();
            var fruits = c.GetFruits();
            
            Console.WriteLine(fruits);

            var l = new Literals();
            Console.WriteLine(l.MyLiterals("test","test","test","test"));
        }
    }
}
