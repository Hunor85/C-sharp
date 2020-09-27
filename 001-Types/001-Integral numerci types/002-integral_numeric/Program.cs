using System;

namespace _002_integral_numeric
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checking if sbyteMinValue_a equals to sbyteMinValue_b
            Console.WriteLine("---------- SByte Min Value Check ----------");
            sbyte sbyteMinValue_a = sbyte.MinValue;
            sbyte sbyteMinValue_b = -128;
            if (sbyteMinValue_a == sbyteMinValue_b)
            {
                Console.WriteLine("The minimum value of SByte property {0} equals to literal integer {1}. ", 
                sbyteMinValue_a, sbyteMinValue_b);
            } 
            else
            {
                Console.WriteLine("The minimum value of SByte property {0} does not equal to literal integer {1}. ", 
                sbyteMinValue_a, sbyteMinValue_b);
            }
            Console.WriteLine("\n");

            // Checking if sbyteMaxValue_a equals to sbyteMaxValue_b
            Console.WriteLine("---------- SByte Max Value Check ----------");
            sbyte sbyteMaxValue_a = sbyte.MaxValue;
            sbyte sbyteMaxValue_b = 127;
            if (sbyteMaxValue_a == sbyteMaxValue_b)
            {
                Console.WriteLine("The maximum value of SByte property {0} equals to literal integer {1}. ", 
                sbyteMaxValue_a, sbyteMaxValue_b);
            } 
            else
            {
                Console.WriteLine("The maximum value of SByte property {0} does not equal to literal integer {1}. ", 
                sbyteMaxValue_a, sbyteMaxValue_b);
            }
            Console.WriteLine("\n");

            // Checking if byteMinValue_a equals to byteMinValue_b
            Console.WriteLine("---------- Byte Min Value Check ----------");
            byte byteMinValue_a = byte.MinValue;
            byte byteMinValue_b = 0;
            if (byteMinValue_a == byteMinValue_b)
            {
                Console.WriteLine("The minimum value of Byte property {0} equals to literal integer {1}. ", 
                byteMinValue_a, byteMinValue_b);
            } 
            else
            {
                Console.WriteLine("The minimum value of Byte property {0} does not equal to literal integer {1}. ", 
                byteMinValue_a, byteMinValue_b);
            }
            Console.WriteLine("\n");

            // Checking if byteMaxValue_a equals to byteMaxValue_b
            Console.WriteLine("---------- Byte Max Value Check ----------");
            byte byteMaxValue_a = byte.MaxValue;
            byte byteMaxValue_b = 255;
            if (byteMaxValue_a == byteMaxValue_b)
            {
                Console.WriteLine("The maximum value of Byte property {0} equals to literal integer {1}. ", 
                byteMaxValue_a, byteMaxValue_b);
            } 
            else
            {
                Console.WriteLine("The maximum value of Byte property {0} does not equal to literal integer {1}. ", 
                byteMaxValue_a, byteMaxValue_b);
            }
            Console.WriteLine("\n");

            // Checking if shortMinValue_a equals to shortMinValue_b
            Console.WriteLine("---------- Short Min Value Check ----------");
            short shortMinValue_a = short.MinValue;
            short shortMinValue_b = -32768;
            if (shortMinValue_a == shortMinValue_b)
            {
                Console.WriteLine("The minimum value of Short property {0} equals to literal integer {1}. ", 
                shortMinValue_a, shortMinValue_b);
            } 
            else
            {
                Console.WriteLine("The minimum value of Short property {0} does not equal to literal integer {1}. ", 
                shortMinValue_a, shortMinValue_b);
            }
            Console.WriteLine("\n");

            // Checking if shortMaxValue_a equals to shortMaxValue_b
            Console.WriteLine("---------- Short Max Value Check ----------");
            short shortMaxValue_a = short.MaxValue;
            short shortMaxValue_b = 32767;
            if (shortMaxValue_a == shortMaxValue_b)
            {
                Console.WriteLine("The maximum value of Short property {0} equals to literal integer {1}. ", 
                shortMaxValue_a, shortMaxValue_b);
            } 
            else
            {
                Console.WriteLine("The maximum value of Short property {0} does not equal to literal integer {1}. ", 
                shortMaxValue_a, shortMaxValue_b);
            }
            Console.WriteLine("\n");

            // Checking if ushortMinValue_a equals to ushortMinValue_b
            Console.WriteLine("---------- UShort Min Value Check ----------");
            ushort ushortMinValue_a = ushort.MinValue;
            ushort ushortMinValue_b = 0;
            if (ushortMinValue_a == ushortMinValue_b)
            {
                Console.WriteLine("The minimum value of UShort property {0} equals to literal integer {1}. ", 
                ushortMinValue_a, ushortMinValue_b);
            } 
            else
            {
                Console.WriteLine("The minimum value of UShort property {0} does not equal to literal integer {1}. ", 
                ushortMinValue_a, ushortMinValue_b);
            }
            Console.WriteLine("\n");

            // Checking if ushortMaxValue_a equals to ushortMaxValue_b
            Console.WriteLine("---------- UShort Max Value Check ----------");
            ushort ushortMaxValue_a = ushort.MaxValue;
            ushort ushortMaxValue_b = 65535;
            if (ushortMaxValue_a == ushortMaxValue_b)
            {
                Console.WriteLine("The maximum value of UShort property {0} equals to literal integer {1}. ", 
                ushortMaxValue_a, ushortMaxValue_b);
            } 
            else
            {
                Console.WriteLine("The maximum value of UShort property {0} does not equal to literal integer {1}. ", 
                ushortMaxValue_a, ushortMaxValue_b);
            }
            Console.WriteLine("\n");

            // Checking if intMinValue_a equals to intMinValue_b
            Console.WriteLine("---------- Int Min Value Check ----------");
            int intMinValue_a = int.MinValue;
            int intMinValue_b = -2147483648;
            if (intMinValue_a == intMinValue_b)
            {
                Console.WriteLine("The minimum value of Int property {0} equals to literal integer {1}. ", 
                intMinValue_a, intMinValue_b);
            } 
            else
            {
                Console.WriteLine("The minimum value of Int property {0} does not equal to literal integer {1}. ", 
                intMinValue_a, intMinValue_b);
            }
            Console.WriteLine("\n");

            // Checking if intMaxValue_a equals to intMaxValue_b
            Console.WriteLine("---------- Int Max Value Check ----------");
            int intMaxValue_a = int.MaxValue;
            int intMaxValue_b = 2147483647;
            if (intMaxValue_a == intMaxValue_b)
            {
                Console.WriteLine("The maximum value of Int property {0} equals to literal integer {1}. ", 
                intMaxValue_a, intMaxValue_b);
            } 
            else
            {
                Console.WriteLine("The maximum value of Int property {0} does not equal to literal integer {1}. ", 
                intMaxValue_a, intMaxValue_b);
            }
            Console.WriteLine("\n");

            // Checking if uintMinValue_a equals to uintMinValue_b
            Console.WriteLine("---------- UInt Min Value Check ----------");
            uint uintMinValue_a = uint.MinValue;
            uint uintMinValue_b = 0;
            if (uintMinValue_a == uintMinValue_b)
            {
                Console.WriteLine("The minimum value of UInt property {0} equals to literal integer {1}. ", 
                uintMinValue_a, uintMinValue_b);
            } 
            else
            {
                Console.WriteLine("The minimum value of UInt property {0} does not equal to literal integer {1}. ", 
                uintMinValue_a, uintMinValue_b);
            }
            Console.WriteLine("\n");

            // Checking if uintMaxValue_a equals to uintMaxValue_b
            Console.WriteLine("---------- UInt Max Value Check ----------");
            uint uintMaxValue_a = uint.MaxValue;
            uint uintMaxValue_b = 4294967295;
            if (uintMaxValue_a == uintMaxValue_b)
            {
                Console.WriteLine("The maximum value of UInt property {0} equals to literal integer {1}. ", 
                uintMaxValue_a, uintMaxValue_b);
            } 
            else
            {
                Console.WriteLine("The maximum value of UInt property {0} does not equal to literal integer {1}. ", 
                uintMaxValue_a, uintMaxValue_b);
            }
            Console.WriteLine("\n");

            // Checking longMinValue_a equals to longMinValue_b
            Console.WriteLine("---------- Long Min Value Check ----------");
            long longMinValue_a = long.MinValue;
            long longMinValue_b = -9223372036854775808;
            if (longMinValue_a == longMinValue_b)
            {
                Console.WriteLine("The minimum value of Long property {0} equals to literal integer {1}. ", 
                longMinValue_a, longMinValue_b);
            } 
            else
            {
                Console.WriteLine("The minimum value of Long property {0} does not equal to literal integer {1}. ", 
                longMinValue_a, longMinValue_b);
            }
            Console.WriteLine("\n");

            // Checking longMaxValue_a equals to longMaxValue_b
            Console.WriteLine("---------- Long Max Value Check ----------");
            long longMaxValue_a = long.MaxValue;
            long longMaxValue_b = 9223372036854775807;
            if (longMaxValue_a == longMaxValue_b)
            {
                Console.WriteLine("The maximum value of Long property {0} equals to literal integer {1}. ", 
                longMaxValue_a, longMaxValue_b);
            } 
            else
            {
                Console.WriteLine("The maximum value of Long property {0} does not equal to literal integer {1}. ", 
                longMaxValue_a, longMaxValue_b);
            }
            Console.WriteLine("\n");

            // Checking ulongMinValue_a equals to ulongMinValue_b
            Console.WriteLine("---------- ULong Min Value Check ----------");
            ulong ulongMinValue_a = ulong.MinValue;
            ulong ulongMinValue_b = 0;
            if (ulongMinValue_a == ulongMinValue_b)
            {
                Console.WriteLine("The minimum value of ULong property {0} equals to literal integer {1}. ", 
                ulongMinValue_a, ulongMinValue_b);
            } 
            else
            {
                Console.WriteLine("The minimum value of ULong property {0} does not equal to literal integer {1}. ", 
                ulongMinValue_a, ulongMinValue_b);
            }
            Console.WriteLine("\n");

            // Checking ulongMaxValue_a equals to ulongMaxValue_b
            Console.WriteLine("---------- ULong Max Value Check ----------");
            ulong ulongMaxValue_a = ulong.MaxValue;
            ulong ulongMaxValue_b = 18446744073709551615;
            if (ulongMaxValue_a == ulongMaxValue_b)
            {
                Console.WriteLine("The maximum value of ULong property {0} equals to literal integer {1}. ", 
                ulongMaxValue_a, ulongMaxValue_b);
            } 
            else
            {
                Console.WriteLine("The maximum value of ULong property {0} does not equal to literal integer {1}. ", 
                ulongMaxValue_a, ulongMaxValue_b);
            }
            Console.WriteLine("\n");
        }
    }
}
