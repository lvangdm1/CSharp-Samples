using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildConstructor
{
    abstract class Computer
    {
        protected string _name = "Unknown";

        // using getter/setter will allow above to be accessed.

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
    }
}
