using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Laptop: Computer
    {
        public Laptop(string name) : base(name)
        {
            Console.WriteLine("Called from Laptop");
        }
    }
}
