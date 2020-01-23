using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class InvoicePrinter
    {
        public void Print(Invoice invoice)
        {

            // pass values to invoice.
            Invoice p1 = new Invoice();
            var x = p1.Subtotal = 5;
            var y = p1.TaxRate = 6;

            // run calculate method.
            var z = p1.CalculateTotal();
            Console.WriteLine(z);

            // 
            var itcv = new InvoiceTotalValidator();
            var result = itcv.Validate(p1);
            Console.WriteLine("total: " + result);

            var itrc = new InvoiceTaxRateCalculator();
            var rc = itrc.Validate(p1);
            Console.WriteLine("TaxRate: " + rc);

            var isv = new InvoiceSubtotalValidator();
            var sv = isv.Validate(p1);
            Console.WriteLine("Subtotal: " + sv);

            var itv = new InvoiceTaxValidator();
            var tv = itv.Validate(p1);
            Console.WriteLine("Tax: " + tv);

            //need to figure this out later.
            var iv = new List<InvoiceValidator>();

        }
    }
}
