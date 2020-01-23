using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateConstructors
{
    class OverloadedConstructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public OverloadedConstructor(int i, string n, float s)
        {
            ID = i;
            Name = n;
            Salary = s;

            Console.WriteLine("First Param");
        }
        public OverloadedConstructor(int a, string b) 
        {
            ID = a;
            Name = b;

            Console.WriteLine(ID + " Second Param " + Name);

        }
        public void Display()
        {
            Console.WriteLine(ID + " " + Name + " " + Salary);
        }
    }
}
