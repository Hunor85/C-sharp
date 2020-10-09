using System;

namespace _001_sbyte
{
    class Program
    {
        /* 
        * Explicit conversion 
        * From sbyte
        * To byte, ushort, uint, or ulong
        * From byte to sbyte
        */
        static void Main(string[] args)
        {
            sbyte val1 = sbyte.MinValue;
            sbyte val2 = sbyte.MaxValue;

            byte val3 = (byte)val1;
            Console.WriteLine(val3.GetTypeCode());

            byte val4 = (byte)val2;
            Console.WriteLine(val4.GetTypeCode());

            ushort val5 = (ushort)val1;
            Console.WriteLine(val5.GetTypeCode());

            ushort val6 = (ushort)val2;
            Console.WriteLine(val6.GetTypeCode());

            uint val7 = (uint)val1;
            Console.WriteLine(val7.GetTypeCode());

            uint val8 = (uint)val2;
            Console.WriteLine(val8.GetTypeCode());

            ulong val9 = (ulong)val1;
            Console.WriteLine(val9.GetTypeCode());

            ulong val10 = (ulong)val2;
            Console.WriteLine(val10.GetTypeCode());

            byte val11 = byte.MinValue;
            byte val12 = byte.MaxValue;

            sbyte val13 = (sbyte)val11;
            Console.WriteLine(val13.GetTypeCode());

            sbyte val14 = (sbyte)val12;
            Console.WriteLine(val14.GetTypeCode());
        }
    }
}
