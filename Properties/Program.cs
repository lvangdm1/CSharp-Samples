using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Computer();
            // uncommenting below will chg the value.
            // comp.name = "Generic Computer";

            Console.WriteLine("Computer name - " + comp.name);
        }
    }
}
