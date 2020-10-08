using System;

namespace _005_int
{
    class Program
    {
        /* 
        * Implicit conversion 
        * From int
        * To long, float, double, or decimal
        */
        static void Main(string[] args)
        {
            int val1 = Int32.MinValue;
            int val2 = Int32.MaxValue;

            long val3 = val1;
            Console.WriteLine(val3.GetType());

            long val4 = val2;
            Console.WriteLine(val4.GetType());

            float v5 = val1;
            Console.WriteLine(v5.GetType());

            float v6 = val2;
            Console.WriteLine(v6.GetType());

            double v7 = val1;
            Console.WriteLine(v7.GetType());

            double v8 = val2;
            Console.WriteLine(v8.GetType());

            decimal v9 = val1;
            Console.WriteLine(v9.GetType());

            decimal v10 = val2;
            Console.WriteLine(v10.GetType());
        }
    }
}
