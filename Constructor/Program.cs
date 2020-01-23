using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Laptop("Generic Computer");
            // changing the setter to private disables below.
            // comp.name = "Generic Computer";

            Console.WriteLine("Computer name - " + comp.name);
        }
    }
}
