using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAdapter
{
    class GalaxyAdapter : IIOS
    {
        private readonly Galaxy _galaxy;

        public GalaxyAdapter(Galaxy galaxy)
        {
            _galaxy = galaxy;
        }
        public void Charging()
        {
            _galaxy.Charging();
            Console.WriteLine("Charging..");
        }

        public void Safari()
        {
            _galaxy.Google();
        }
    }
}
