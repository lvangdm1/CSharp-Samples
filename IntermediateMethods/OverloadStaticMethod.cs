using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateMethods
{
    class OverloadStaticMethod
    {
        // this is overloading a method.
        public static float AverageScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;

            return result;
        }
        // this is overloading a method by creating a second method with different variables.
        public static string AverageScores(string a, string b, string c)
        {
            var result = a + b + c;

            return result;
        }
        // Overload example using Function Bodied Expression.
        public static int AverageScores(int a, int b, int c) => (a + b + c);

    }
}
