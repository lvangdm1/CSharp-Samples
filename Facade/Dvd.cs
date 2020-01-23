using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Dvd
    {
        public Dvd(string name)
        {
            Movie = name;
        }
        public string Movie { get; set; }

    }
}
