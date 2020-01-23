using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class InvoicePrinter
    {
        // This makes in Single responsibility.
        // (Invoice invoice) is a single instance.
        public void Print(Invoice invoice)
        {
            // pass values to invoice.
            Invoice p1 = new Invoice();
            var x = p1.Subtotal = 5;
            var y = p1.TaxRate = 6;

            // run calculate method.
            var z = p1.CalculateTotal();
            Console.WriteLine(z);
        }
    }
}
