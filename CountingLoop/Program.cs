using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 5; x++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
