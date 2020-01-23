using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = "true";

            if (value != "true")
            {
                Console.WriteLine("not true");
            }
            else
            {
                Console.WriteLine("is true");
            }
        }
    }
}
