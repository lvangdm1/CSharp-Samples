using System;
using System.Collections.Generic;
using System.Text;

namespace Testme
{
    class MySubName
    {
        protected string _name = "Unknown";

        public string name
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
        public MySubName(string name)
        {
            this.name = name;
        }
    }
}
