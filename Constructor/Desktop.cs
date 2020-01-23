using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Desktop : Computer
    {
        public Desktop(string name) : base(name)
        {
            Console.WriteLine("Called from Desktop");
        }
    }
}
