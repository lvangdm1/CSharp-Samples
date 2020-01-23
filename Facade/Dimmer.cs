using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Dimmer
    {
        internal void Dim(int val)
        {
            Console.WriteLine(val == 10 ? "turning lights on" : $"Dimming lights to {val}");
        }

        internal void Off() => Console.WriteLine("Switching off lights");

    }
}
