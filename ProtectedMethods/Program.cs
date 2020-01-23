using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Computer();

            // if off, toggle will turn on.
            comp.PowerToggle();
            // if on, toggle will turn off.
            comp.PowerToggle();
            // if off, toggle will turn on.
            comp.PowerToggle();
        }

    }
}
