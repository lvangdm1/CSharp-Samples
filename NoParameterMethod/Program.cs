using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new MyMethod();
            Console.WriteLine(m.MyName());
        }
    }
}
