using System;
using System.Collections;

namespace _004_ushort
{
    /* 
    * Implicit conversion 
    * From ushort
    * To int, uint, long, ulong, float, double, or decimal
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Min Value for UShort
            // Implicit conversion from UShort to Int
            Console.WriteLine("---------- UShort Min to Int ----------");
            ushort ushortMinValueA = ushort.MinValue;
            int intValueA = ushortMinValueA;
            Console.WriteLine("The minimum value for UShort: {0}", ushortMinValueA);
            Console.WriteLine("The type of intValueA: {0}", intValueA.GetTypeCode());

            Console.WriteLine("\n");   

            // Max Value for UShort
            // Implicit conversion from UShort to Int
            Console.WriteLine("---------- UShort Max to Int ----------");
            ushort ushortMaxValueB = ushort.MaxValue;
            int intValueB = ushortMaxValueB;
            Console.WriteLine("The maximum value for UShort: {0}", ushortMaxValueB);
            Console.WriteLine("The type of intValueB: {0}", intValueB.GetTypeCode());   

            Console.WriteLine("\n");  

            // Min Value for UShort
            // Implicit conversion from UShort to UInt
            Console.WriteLine("---------- UShort Min to UInt ----------");
            ushort ushortMinValueC = ushort.MinValue;
            uint uintValueC = ushortMinValueC;
            Console.WriteLine("The minimum value for UShort: {0}", ushortMinValueC);
            Console.WriteLine("The type of uintValueC: {0}", uintValueC.GetTypeCode());

            Console.WriteLine("\n");    

            // Max Value for UShort
            // Implicit conversion from UShort to UInt
            Console.WriteLine("---------- UShort Max to UInt ----------");
            ushort ushortMaxValueD = ushort.MaxValue;
            uint uintValueD = ushortMaxValueD;
            Console.WriteLine("The maximum value for UShort: {0}", ushortMaxValueD);
            Console.WriteLine("The type of uintValueD: {0}", uintValueD.GetTypeCode());

            Console.WriteLine("\n");   

            // Min Value for UShort
            // Implicit conversion from UShort to Long
            Console.WriteLine("---------- UShort Min to Long ----------");
            ushort ushortMinValueE = ushort.MinValue;
            long longValueE = ushortMinValueE;
            Console.WriteLine("The minimum value for UShort: {0}", ushortMinValueE);
            Console.WriteLine("The type of longValueE: {0}", longValueE.GetTypeCode());

            Console.WriteLine("\n"); 

            ushort valueA = ushort.MinValue;
            ushort valueB = ushort.MaxValue;

            // Implicit conversion from UShort.MaxValue to Long
            long valueF = valueB;
            Console.WriteLine(valueF.GetTypeCode());
            Console.WriteLine(valueF.GetType());    

            Console.WriteLine("\n"); 

            // Implicit conversion from UShort.MinValue to ULong
            ulong valueG = valueA;
            Console.WriteLine(valueG.GetTypeCode());
            Console.WriteLine(valueG.GetType());

            Console.WriteLine("\n"); 

            // Implicit conversion from UShort.MaxValue to ULong
            ulong valueH = valueB;
            Console.WriteLine(valueH.GetTypeCode());
            Console.WriteLine(valueH.GetType());

            Console.WriteLine("\n"); 

            // Implicit conversion from UShort.MinValue to Float
            float valueI = valueA;
            Console.WriteLine(valueI.GetTypeCode());
            Console.WriteLine(valueI.GetType());   

            Console.WriteLine("\n"); 

            // Implicit conversion from UShort.MaxValue to Float
            float valueJ = valueB;
            Console.WriteLine(valueJ.GetTypeCode());
            Console.WriteLine(valueJ.GetType());           

            Console.WriteLine("\n"); 

            // Implicit conversion from UShort.MinValue to Double
            double valueK = valueA;
            Console.WriteLine(valueK.GetTypeCode());
            Console.WriteLine(valueK.GetType());   

            Console.WriteLine("\n"); 

            // Implicit conversion from UShort.MaxValue to Double
            double valueL = valueB;
            Console.WriteLine(valueL.GetTypeCode());
            Console.WriteLine(valueL.GetType()); 

            Console.WriteLine("\n"); 

             // Implicit conversion from UShort.MinValue to Decimal
            decimal valueM = valueA;
            Console.WriteLine(valueM.GetTypeCode());
            Console.WriteLine(valueM.GetType());   

            Console.WriteLine("\n"); 

            // Implicit conversion from UShort.MaxValue to Decimal
            decimal valueN = valueB;
            Console.WriteLine(valueN.GetTypeCode());
            Console.WriteLine(valueN.GetType());            
        }
    }
}
