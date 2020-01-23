using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen_Interface
{
    class Cello : IPen
    {
        public string color { get; set; }
        private bool IsOpen = true;

        public bool Close()
        {
            IsOpen = false;
            color = "No color";
            Console.WriteLine("Pen is closed " + color);
            return IsOpen;
        }

        public bool Open()
        {
            IsOpen = true;
            color = "black";
            Console.WriteLine("Pen is open " + color);
            return IsOpen;
        }

        public void Write(string Text)
        {
            Console.WriteLine("Writing text");
        }
    }
}
