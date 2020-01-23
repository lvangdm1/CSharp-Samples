using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAsConstructor    
{
   
    class Person
    {
        public string name { get; set; }
        public int age { get;  set; }
    public Person(string n, int a)
        {
            name = n;
            age = a;
        }
        // old way, now we use auto properties.
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}
        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}
    }
}
