using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInterface
{
    class SleepController : ISleep
    {
        public bool isSleeping { get; set; }

        public void ToggleSleep()
        {
            isSleeping = !isSleeping;
        }
    }
}
