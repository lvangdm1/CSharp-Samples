using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingInterfaces
{
    interface IScored
    {
        int Score { get; set; }
        int MaxScore { get; set; }
    }
}
