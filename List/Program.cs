using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var StudentName = new List<string>();
            var StudentGrade = new List<int>();

            StudentName.Add("Lee");
            StudentName.Add("Anna");

            StudentGrade.Add(80);
            StudentGrade.Add(90);

            Console.WriteLine(StudentName[0]);
            Console.WriteLine(StudentGrade[1]);

        }
    }
}
