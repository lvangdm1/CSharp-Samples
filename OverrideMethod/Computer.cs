using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod
{
    abstract class Computer
    {
        protected string _name = "Unknown";
        public bool isOn { get; private set; }

        // using virtual here will allow name property overriding.
        public virtual string name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        public Computer(string name)
        {
            this.name = name;
        }
        protected void TurnOn()
        {
            isOn = true;
        }
        protected void TurnOff() 
        {
            isOn = false;
        }
        public virtual void TogglePower()
        {
            if(isOn)
            {
                TurnOff();
            }else
            {
                TurnOn();
            }
        }

    }
}
