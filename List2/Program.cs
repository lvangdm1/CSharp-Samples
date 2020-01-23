using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            var StudentName = new List<string>();
            var StudentGrade = new List<int>();

            var adding = true;

            while(adding)
            {
                Console.WriteLine("Student name");
                StudentName.Add(Console.ReadLine());

                Console.WriteLine("Student Grade");
                StudentGrade.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() != "y")
                    adding = false;

            }
            for(int x =0;x< StudentName.Count;x++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", StudentName[x],StudentGrade[x]);
            }
        }
    }
}
