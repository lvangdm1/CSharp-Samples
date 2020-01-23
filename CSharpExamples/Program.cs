using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Program();
            m.GetMain();
            var t = GetTour();
        }
        public void GetMain()
        {
            Console.WriteLine("Getting method from Program class");
        }
        private string GetTour()
        {
            return "Museum Tour";
        }
    }
}
