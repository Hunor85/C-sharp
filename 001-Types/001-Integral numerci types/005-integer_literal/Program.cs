﻿using System;

namespace _004_integer_literal
{
    class Program
    {
        /*
         * If the literal is suffixed by U or u, its type is the first of the following types 
         * in which its value can be represented: uint, ulong.
         * For example: var decimalLiteral = 42u;
         */
        static void Main(string[] args)
        {
            // SByte minimum value
            var sbyteMinLiteral = -128u;
            Console.WriteLine("---------- SByte Minimum Value ----------");
            Console.WriteLine("The minimum value for sbyteMinLietral is {0} ", sbyteMinLiteral);
            Console.WriteLine("The type for sbyteMinLiteral is {0} ", sbyteMinLiteral.GetTypeCode());

            Console.WriteLine("\n");

             // SByte maximum value
            var sbyteMaxLiteral = 127u;
            Console.WriteLine("---------- SByte Maximum Value ----------");
            Console.WriteLine("The maximum value for sbyteMaxLiteral is {0} ", sbyteMaxLiteral);
            Console.WriteLine("The type for sbyteMaxLiteral is {0} ", sbyteMaxLiteral.GetTypeCode());

            Console.WriteLine("\n");
            
            // Byte minimum value
            var byteMinLiteral = 0u;
            Console.WriteLine("---------- Byte Minimum Value ----------");
            Console.WriteLine("The minimum value for byteMinLiteral is {0} ", byteMinLiteral);
            Console.WriteLine("The type for byteMinLiteral is {0} ", byteMinLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // Byte maximum value
            var byteMaxLiteral = 255u;
            Console.WriteLine("---------- Byte Maximum Value ----------");
            Console.WriteLine("The maximum value for byteMaxLiteral is {0} ", byteMaxLiteral);
            Console.WriteLine("The type for byteMaxLiteral is {0} ", byteMaxLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // Short minimum value
            var shortMinLiteral = -32768u;
            Console.WriteLine("---------- Short Minimum Value ----------");
            Console.WriteLine("The minimum value for shortMinLiteral is {0} ", shortMinLiteral);
            Console.WriteLine("The type for shortMinLiteral is {0} ", shortMinLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // Short maximum value
            var shortMaxLiteral = 32767u;
            Console.WriteLine("---------- Short Maximum Value ----------");
            Console.WriteLine("The maximum value for shortMaxLiteral is {0} ", shortMaxLiteral);
            Console.WriteLine("The type for shortMaxLiteral is {0} ", shortMaxLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // UShort minimum value
            var ushortMinLiteral = 0u;
            Console.WriteLine("---------- UShort Minimum Value ----------");
            Console.WriteLine("The minimum value for ushortMinLiteral is {0} ", ushortMinLiteral);
            Console.WriteLine("The type for ushortMinLiteral is {0} ", ushortMinLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // UShort maximum value
            var ushortMaxLiteral = 65535u;
            Console.WriteLine("---------- UShort Maximum Value ----------");
            Console.WriteLine("The maximum value for ushortMaxLiteral is {0} ", ushortMaxLiteral);
            Console.WriteLine("The type for ushortMaxLiteral is {0} ", ushortMaxLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // Int minimum value
            var intMinLiteral = -2147483648u;
            Console.WriteLine("---------- Int Minimum Value ----------");
            Console.WriteLine("The minimum value for intMinLiteral is {0} ", intMinLiteral);
            Console.WriteLine("The type for intMinLiteral is {0} ", intMinLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // Int maximum value
            var intMaxLiteral = 2147483647u;
            Console.WriteLine("---------- Int Maximum Value ----------");
            Console.WriteLine("The maximum value for intMaxLiteral is {0} ", intMaxLiteral);
            Console.WriteLine("The type for intMaxLiteral is {0} ", intMaxLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // UInt minimum value
            var uintMinLiteral = 0u;
            Console.WriteLine("---------- UInt Minimum Value ----------");
            Console.WriteLine("The minimum value for uintMinLiteral is {0} ", uintMinLiteral);
            Console.WriteLine("The type for uintMinLiteral is {0} ", uintMinLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // UInt maximum value
            var uintMaxLiteral = 4294967295u;
            Console.WriteLine("---------- UInt Maximum Value ----------");
            Console.WriteLine("The maximum value for uintMaxLiteral is {0} ", uintMaxLiteral);
            Console.WriteLine("The type for uintMaxLiteral is {0} ", uintMaxLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // Long minimum value
            var longMinLiteral = -9223372036854775808; // "U" or "u" suffix CANNOT be used
            //var l = -4_294_967_296u; 
            // UInt16.MinValue-1=-4_294_967_296 gives CS0023 exception if "u" or "U" suffix is used
            Console.WriteLine("---------- Long Minimum Value ----------");
            Console.WriteLine("The minimum value for longMinLiteral is {0} ", longMinLiteral);
            Console.WriteLine("The type for longMinLiteral is {0} ", longMinLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // Long maximum value
            var longMaxLiteral = 9223372036854775807u;
            Console.WriteLine("---------- Long Maximum Value ----------");
            Console.WriteLine("The maximum value for longMaxLiteral is {0} ", longMaxLiteral);
            Console.WriteLine("The type for longMaxLiteral is {0} ", longMaxLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // ULong minimum value
            var ulongMinLiteral = 0u;
            Console.WriteLine("---------- ULong Minimum Value ----------");
            Console.WriteLine("The minimum value for ulongMinLiteral is {0} ", ulongMinLiteral);
            Console.WriteLine("The type for ulongMinLiteral is {0} ", ulongMinLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // ULong maximum value
            var ulongMaxLiteral = 18446744073709551615u;
            Console.WriteLine("---------- ULong Maximum Value ----------");
            Console.WriteLine("The maximum value for ulongMaxLiteral is {0} ", ulongMaxLiteral);
            Console.WriteLine("The type for ulongMaxLiteral is {0} ", ulongMaxLiteral.GetTypeCode());

            Console.WriteLine("\n");

            // What if UInt32.MaxValue + 1?
            var uintMaxLiteralPlusOne = 4294967296u;
            Console.WriteLine("---------- UInt32.MaxValue + 1 ----------");
            Console.WriteLine("The maximum value for uintMaxLiteralPlusOne is {0} ", uintMaxLiteralPlusOne);
            Console.WriteLine("The type for uintMaxLiteralPlusOne is {0} ", uintMaxLiteralPlusOne.GetTypeCode());

            Console.WriteLine("\n");

            // ULong maximum value
            var ulongMaxLiteral2 = 11446744073709511615u;
            Console.WriteLine("---------- ULong Maximum Value ----------");
            Console.WriteLine("The maximum value for ulongMaxLiteral2 is {0} ", ulongMaxLiteral2);
            Console.WriteLine("The type for ulongMaxLiteral2 is {0} ", ulongMaxLiteral2.GetTypeCode());

            Console.WriteLine("\n");

            var joo = -2147483648u;
            Console.WriteLine("---------- Int32 min value +1, -2147483649----------");
            Console.WriteLine("The type for joo is {0} ", joo.GetTypeCode());
        }
    }
}
