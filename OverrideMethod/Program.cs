using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);

            // this will be bypassed to Desktop base.name.
            Console.WriteLine("Computer name - " + comp.name);
            Console.WriteLine("Computer name - " + comp.caseType);

            //comp.TogglePower();
            comp.TogglePower();
            //comp.ToggleSleep();
            Console.WriteLine("Computer is on - " + comp.isOn);

            comp.ToggleSleep();
            Console.WriteLine("Computer is sleeping - " + comp.isSleeping);

            comp.ToggleSleep();
            Console.WriteLine("Computer is sleeping - " + comp.isSleeping);

            comp.TogglePower();
            Console.WriteLine("Computer is on - " + comp.isOn);
        }
    }
}
