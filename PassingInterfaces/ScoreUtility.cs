using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingInterfaces
{
    class ScoreUtility
    {
        //public int ass1 { get; set; }
        //public int ass2 { get; set; } 
        public static IScored BestScore(IScored assign1, IScored assign2)
        {
            
            assign1.Score = 3;
            assign1.MaxScore = 5;
            assign2.Score = 7;
            assign2.MaxScore = 2;


            var score1 = assign1.Score + assign1.MaxScore;
            var score2 = assign2.Score + assign2.MaxScore;

            if (score1 > score2)
            {
                var result = "first";
                Console.WriteLine(result);
                return assign1;
            }
            else
            {
                var result = "Second";
                Console.WriteLine(result);
                return assign2;
            }
        }
    }
}
