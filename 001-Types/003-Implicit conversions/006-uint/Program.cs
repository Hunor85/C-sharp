using System;

namespace _006_uint
{
    class Program
    {
        /* 
        * Implicit conversion 
        * From uint
        * To long, ulong, float, double, or decimal
        */
        static void Main(string[] args)
        {
            uint val1 = uint.MinValue;
            uint val2 = uint.MaxValue;

            long val3 = val1;
            Console.WriteLine(val3.GetTypeCode());

            long val4 = val2;
            Console.WriteLine(val4.GetTypeCode());

            ulong val5 = val1;
            Console.WriteLine(val5.GetTypeCode());

            ulong val6 = val2;
            Console.WriteLine(val6.GetTypeCode());

            float val7 = val1;
            Console.WriteLine(val7.GetTypeCode());

            float val8 = val2;
            Console.WriteLine(val8.GetTypeCode());

            double val9 = val1;
            Console.WriteLine(val9.GetTypeCode());

            double val10 = val2;
            Console.WriteLine(val10.GetTypeCode());

            decimal val11 = val1;
            Console.WriteLine(val11.GetTypeCode());

            decimal val12 = val2;
            Console.WriteLine(val12.GetTypeCode());
        }
    }
}
