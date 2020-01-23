using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Invoice
    {
        public decimal Subtotal { get; set; }
        public decimal TaxRate { get; set; }

        public decimal CalculateTax()
        {
            return Subtotal * TaxRate / 100;
        }
        // calculate total with tax rate.
        public decimal CalculateTotal()
        {
            return Subtotal + CalculateTax();
        }
    }
}
