﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class InvoiceValidator
    {
        private List<Validator> _validators;

        public InvoiceValidator(List<Validator> validators)
        {
            _validators = validators;
        }
        public bool Validate(Invoice invoice)
        {
            return _validators.All(v => v.Validate(invoice));
        }
    }
}
