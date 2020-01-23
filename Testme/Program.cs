using System;

namespace Testme
{
    class Program
    {
        static void Main(string[] args)
        {
            var mymeth = new GetAbstract();
            Console.WriteLine(mymeth.Scores(5, 6));
            var gp = mymeth.FName;
            Console.WriteLine(gp);
            var gp2 = mymeth.Score();
            Console.WriteLine(gp2);
        }
    }
}
