using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAdapter
{
    // inherits IAndroid interface to get properties.
    class IPhoneAdapter: IAndroid
    {
        private readonly IPhone _iphone;
        public IPhoneAdapter(IPhone phone)
        {
            _iphone = phone;
        }
        // converts Galaxy charger to IPhone.
        public void Charging()
        {
        // to IPhone charger
            _iphone.Charging();
            Console.WriteLine("Charging..");
        }
        // converts Google browser to Safari.
        public void Google()
        {
        // to IPhone Safari browser
            _iphone.Safari();
        }
    }
}
