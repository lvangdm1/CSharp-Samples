using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new StringMethod();
            Console.WriteLine(s.GetName("Anna from Main"));

            var num = new IntMethod();
            Console.WriteLine(num.GetNumber(4,5));
        }
    }
}
