using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateMethods
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Static: must access the properties directly, can't instanstiate.
            Console.WriteLine(OverloadStaticMethod.AverageScores(5, 6, 7));

            Console.WriteLine(OverloadStaticMethod.AverageScores("Hi ", "My ", "Friend"));
        }
    }
}
