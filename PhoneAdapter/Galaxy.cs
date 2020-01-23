using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAdapter
{
    class Galaxy : IAndroid
    {
        public void Charging()
        {
            Console.WriteLine("Galaxy Charger connected");
        }

        public void Google()
        {
            Console.WriteLine("Opening Google browser");
        }
    }
}
