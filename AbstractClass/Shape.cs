using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Shape
    {
        // changed to abstract class to be inherited.
        public abstract int GetArea();
        public void Display()
        {
            Console.WriteLine("The area is {0}", GetArea());
        }
    }

    class Square: Shape
    {
        public int Width;
        // if abstract then Shape inheritance and override is needed.
        public override int GetArea()
        {
            return Width * Width;
        }
    }
    class Square2 : Shape
    {
        public int Width;
        // if abstract then Shape inheritance and override is needed.
        public override int GetArea()
        {
            return Width + Width;
        }
    }
}
