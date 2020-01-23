using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FooBar();
            fb.SomeMethod();
            var foo = fb as IFoo;
            foo.SomeMethod();
            var bar = fb as IBar;
            bar.SomeMethod();
        }
    }
}
