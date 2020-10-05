using System;

namespace _001_sbyte
{
    class Program
    {
        /* 
         * Implicit conversion 
         * From sbyte
         * To short, int, long, float, double, or decimal
         */

        static void Main(string[] args)
        {
            // Min Value for SByte
            Console.WriteLine("---------- SByte Min ----------");
            sbyte sbyteMinValue = sbyte.MinValue;
            short shortValueA = sbyteMinValue;
            Console.WriteLine("The minimum value for SByte: {0}", sbyteMinValue);
            Console.WriteLine("The type of shortValeA: {0}", shortValueA.GetTypeCode());

            // Max Value for SByte
            Console.WriteLine("---------- SByte Max ----------");
            sbyte sbyteMaxValue = sbyte.MaxValue;
            short shortValueB = sbyteMaxValue;
            Console.WriteLine("The maximum value for SByte: {0}", sbyteMaxValue);
            Console.WriteLine("The type of shortValeB: {0}", shortValueB.GetTypeCode());

            
        }
    }
}
