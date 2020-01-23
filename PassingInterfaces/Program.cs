using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new ScoreUtility();
            //s.BestScore();
            //var ss = new IScored();
            //Still not resolved.
            //ScoreUtility.BestScore();

            Console.WriteLine(s);
        }
    }
}
