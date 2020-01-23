using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var cello = new Cello();
            cello.Open();
            cello.Write("run method");
            cello.Close();
        }
    }
}
