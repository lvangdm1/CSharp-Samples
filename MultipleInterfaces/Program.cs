using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Document();

            d.Decrypt();
            d.Encrypt();
            d.Load();
            d.Save();
        }
    }
}
