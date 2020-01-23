using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var kid = new Student();
            var kid2 = new Student2();

            var gp = kid.FirstName;
            var gp2 = kid.LastName;
            var gp3 = kid.Email;

            var gp4 = kid.StudentName;

            // use the abstract method.
            var gp5 = kid.ComputeGradeAverage();
            Console.WriteLine(gp5);
            // dynamic polymorphism with abstract method.
            var gp6 = kid2.ComputeGradeAverage();
            Console.WriteLine(gp6);
        }
    }
}
