﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafety
{
    class Program
    {
        static Math objMaths = new Math();
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(objMaths.Divide);
            t1.Start(); // Child thread
            objMaths.Divide(); // main thread
        }

        class Math
        {
            public int Num1;
            public int Num2;

            Random o = new Random();

            public void Divide()
            {
                for (long i = 0; i < 100000; i++)
                {
                    //lock will allow only 1 thread to run.
                    lock (this)
                    {
                        Num1 = o.Next(1, 2);
                        Num2 = o.Next(1, 2);
                        int result = Num1 / Num2; // Main thread
                        Num1 = 0;
                        Num2 = 0; // Child thread
                    }
                }
            }
        }
    }
}
