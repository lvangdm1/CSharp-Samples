using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateMethods
{
    class StaticMethod
    {
        public static float AverageScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;

            return result;
        }
    }
}
