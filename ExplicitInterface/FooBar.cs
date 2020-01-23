using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    class FooBar : IFoo, IBar
    {
        void IFoo.SomeMethod() 
        {
            Console.WriteLine("IFoo's Method");
        }
        void IBar.SomeMethod() 
        {
            Console.WriteLine("IBar's Method");
        }
        public void SomeMethod()
        {
            Console.WriteLine("FooBar's Method");
        }
    }
}
