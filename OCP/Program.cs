using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate both to pass the class as parameter.
            var i = new Invoice();
            var ii = new InvoicePrinter();

            // This will run the method.
            ii.Print(i);

            

         }
    }
}
