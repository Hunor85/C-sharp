using System;

namespace _009_float
{
    class Program
    {
        /* 
        * Implicit conversion 
        * From float
        * To double
        */
        static void Main(string[] args)
        {
            float v1 = float.MinValue;
            float v2 = float.MaxValue;

            double v3 = v1;
            Console.WriteLine(v3.GetType());

            double v4 = v2;
            Console.WriteLine(v4.GetType());
        }
    }
}
