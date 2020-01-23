using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAsConstructor 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original method to get name and age.
            Person p1 = new Person("Anna", 20);
            Console.WriteLine("Before: {0}, {1}", p1.name, p1.age);
            // Passing class with new values.
            ChangePerson(p1);
            Console.WriteLine("After: {0}, {1}", p1.name, p1.age);
            // Showing that p2 accesses the same memory location as p1.
            Person p2 = p1;
            p2.name = "John";
            Console.WriteLine("Reference: {0}, {1}", p1.name, p1.age);
        }
        public static void ChangePerson(Person p1)
        {
            p1.name = "Lee";
            p1.age = 50;
        }
    }
}
