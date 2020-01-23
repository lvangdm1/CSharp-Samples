using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);

            // this will be bypassed to Desktop base.name.
            Console.WriteLine("Computer name - " + comp.name);
            Console.WriteLine("Computer name - " + comp.caseType);
        }
    }
}
