using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // connect to the adapter.
            var Iphone = new IPhone(); 
            var adapter = new IPhoneAdapter(Iphone);

            // using the adapter.
            Tester(adapter);
        }
            // accessing IAndroid galaxy first through adapter.
        private static void Tester(IAndroid galaxy)
        {
            // accessing galaxy properties.
            galaxy.Charging();
            galaxy.Google();
        }
    }
}
