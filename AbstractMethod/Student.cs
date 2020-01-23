using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    // inherits Person with abstract class.
    class Student : Person
    {
        public string StudentName { get; set; }
        // override to use abstract method.
        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }
    }
    class Student2 : Person
    {
        public string StudentName { get; set; }
        // Can acheive dynamic polymorphism with abstract method.
        public override float ComputeGradeAverage()
        {
            return 5 * 4.0f;
        }
    }


}
