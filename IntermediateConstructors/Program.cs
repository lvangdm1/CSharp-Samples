using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new ParameterConstructor(5, "Anna", 4f);

            var Second = new OverloadedConstructor(6, "Lee");
            // since second doesn't have a float value, it shows as zero.
            Second.Display();

            var cc = new ConstructiveChaining("test");
            
        }
    }
}
