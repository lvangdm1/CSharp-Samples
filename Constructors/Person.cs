using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        private int PersonID { get; set; }
        private string FirstName, LastName, City; 
        public Person()
        {
            PersonID = 1;
            FirstName = "Anna";
            LastName = "Smith";
            City = "Des Moines";
            Console.WriteLine("This is from the Person constructor");
        }
        public void Display()  
        {
            Console.WriteLine(PersonID + " " + FirstName + " " + LastName + " " + City);
        }
    }
}
