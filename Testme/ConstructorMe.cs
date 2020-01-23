using System;
using System.Collections.Generic;
using System.Text;

namespace Testme
{
    class ConstructorMe : MySubName
    {
        public string MyName{ get;set;}
        public int Num { get; set; }

        public enum SubName
        {
            Billy,
            Mike
        }
        public SubName subName { get; private set; }

        public ConstructorMe(string n, int i, SubName subName): base(n)
        {
            this.subName = subName;
            MyName = n;
            Num = i;

            //from Overload
            Console.WriteLine("testfromOverloadedConstuctor");

        }
        //optional void method
        public void DisplayMe()
        {
            Console.WriteLine("Hello " + MyName + " you are " + Num);
        }
    }
}
