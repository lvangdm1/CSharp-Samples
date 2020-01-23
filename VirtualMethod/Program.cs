using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var kid = new Student();

            // for virtual method to merge with SendMessage.
            var gp5 = kid.SendMessage("hi");
            Console.WriteLine(gp5);
        }
    }
}
