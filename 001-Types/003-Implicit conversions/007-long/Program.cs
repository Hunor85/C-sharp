﻿using System;

namespace _007_long
{
    class Program
    {
        /* 
        * Implicit conversion 
        * From long
        * To float, double, or decimal
        */
        static void Main(string[] args)
        {
            long val1 = long.MinValue;
            long val2 = long.MaxValue;

            float v3 = val1;
            Console.WriteLine(v3.GetType());

            float v4 = val2;
            Console.WriteLine(v4.GetType());

            double v5 = val1;
            Console.WriteLine(v5.GetType());

            double v6 = val2;
            Console.WriteLine(v6.GetType());

            decimal v7 = val1;
            Console.WriteLine(v7.GetType());

            decimal v8 = val2;
            Console.WriteLine(v8.GetType());
        }
    }
}
