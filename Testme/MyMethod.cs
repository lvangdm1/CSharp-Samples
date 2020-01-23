using System;
using System.Collections.Generic;
using System.Text;

namespace Testme
{
    public abstract class MyMethod
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public abstract int Score();
        public int Scores(int a, int b)
        {
            FName = "Bob";

        int results;
            results = a + b;
            Console.WriteLine("from 1st");
            return results;
        }

        public static int Scores(int a, int b, int c)
        {
            int results;
            results = a + b + c;
            Console.WriteLine("from 2nd");
            return results;
        }
        
    }
}
