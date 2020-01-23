using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateConstructors
{
    class ConstructiveChaining
    {
        public string StrName;
        public ConstructiveChaining()
        {
            Console.WriteLine("First");
        }
        // using this will run both First and Second methods.
        public ConstructiveChaining(string str) : this()
        {
            StrName = str;
            Console.WriteLine("Second");
        }
    }
}
