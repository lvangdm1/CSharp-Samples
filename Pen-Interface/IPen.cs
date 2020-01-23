using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen_Interface
{
    interface IPen
    {
        string color { get; set; }
        bool Open();
        bool Close();
        void Write(string Text); 
        
    }
}
