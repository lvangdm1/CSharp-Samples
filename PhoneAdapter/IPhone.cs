using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAdapter 
{
    class IPhone : IIOS
    {
        public void Charging()
        {
            Console.WriteLine("IPhone Charger connected");
        }

        public void Safari()
        {
            Console.WriteLine("Opening Safari browser");
        }
    }
}
