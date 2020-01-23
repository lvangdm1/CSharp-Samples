using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List3
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                // using method.
                var newStudent = new Student();

                Console.Write("Student Name: ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Student Grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.Write("Student Birthday: ");
                newStudent.Birthday = Console.ReadLine();

                Console.Write("Student Address: ");
                newStudent.Address = Console.ReadLine();

                Console.Write("Student Phone Number: ");
                newStudent.Phone = int.Parse(Console.ReadLine());

                students.Add(newStudent);


                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }
        class Student
        {
            public string Name { get; set; }
            public int Grade { get; set; }
            public string Birthday { get; set; }
            public string Address { get; set; }
            public int Phone { get; set; }

        }
    }
}
