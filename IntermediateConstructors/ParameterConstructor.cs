using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateConstructors
{
    class ParameterConstructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public ParameterConstructor(int i, string n, float s)
        {
            //i = 5;
            //n = "John";
            //s = 30f;
            ID = i;
            Name = n;
            Salary = s;

            

            Console.WriteLine("First Param"+ i + n + s);
        }

    }
}
