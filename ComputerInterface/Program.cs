using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInterface
{
    class Program
    {
        static void Main(string[] args)
        {
             //var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);

             var comp = new Laptop("Generic Laptop", 1024, 768);

            // this will be bypassed to Desktop base.name.
            Console.WriteLine("Computer name - " + comp.name);
           // Console.WriteLine("Computer name - " + comp.caseType);

            comp.TogglePower();
            Console.WriteLine("Computer is on - " + comp.isOn);

            comp.ToggleSleep();
            Console.WriteLine("Computer is sleeping - " + comp.isSleeping);

            comp.TogglePower();
            Console.WriteLine("Computer is on - " + comp.isOn);
        }
    }
}
