using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 1;

            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }
        }
    }
}
