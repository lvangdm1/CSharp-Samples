using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedMethods
{
    class Computer
    {
        public bool IsCompOn { get; set; }

        protected void TurnOn()
        {
            IsCompOn = true;
        }
        protected void TurnOff()
        {
            IsCompOn = false;
        }

        public void PowerToggle()
        {
            if (IsCompOn)
            {
                TurnOff();
                Console.WriteLine("Computer is turned off");
            }
            else
            {
                TurnOn();
                Console.WriteLine("Computer is turned on");
            }
        }
    }
}
