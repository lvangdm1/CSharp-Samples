using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class InvoiceTotalValidator : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            var result = invoice.CalculateTotal() >= 0;
            return result;
        }
    }
}
