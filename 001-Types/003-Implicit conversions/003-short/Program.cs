using System;

namespace _003_short
{
    class Program
    {
        /* 
         * Implicit conversion 
         * From short
         * To int, long, float, double, or decimal
         */
        static void Main(string[] args)
        {
            // Min Value for Short
            // Implicit conversion from Short to Int
            Console.WriteLine("---------- Short Min to Int ----------");
            short shortMinValueA = short.MinValue;
            int intValueA = shortMinValueA;
            Console.WriteLine("The minimum value for Short: {0}", shortMinValueA);
            Console.WriteLine("The type of intValueA: {0}", intValueA.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for Short
            // Implicit conversion from Short to Int
            Console.WriteLine("---------- Short Max to Int ----------");
            short shortMaxValueB = short.MaxValue;
            int intValueB = shortMaxValueB;
            Console.WriteLine("The maximum value for Short: {0}", shortMaxValueB);
            Console.WriteLine("The type of intValueB: {0}", intValueB.GetTypeCode());    

            Console.WriteLine("\n");

            // Min Value for Short
            // Implicit conversion from Short to Long
            Console.WriteLine("---------- Short Min to Long ----------");
            short shortMinValueC = short.MinValue;
            long intValueC = shortMinValueC;
            Console.WriteLine("The minimum value for Short: {0}", shortMinValueC);
            Console.WriteLine("The type of intValueC: {0}", intValueC.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for SHort
            // Implicit conversion from Short to Long
            Console.WriteLine("---------- SByte Max to Long ----------");
            short shortMaxValueD = short.MaxValue;
            long intValueD = shortMaxValueD;
            Console.WriteLine("The maximum value for Short: {0}", shortMaxValueD);
            Console.WriteLine("The type of intValueD: {0}", intValueD.GetTypeCode());    

            Console.WriteLine("\n");            

            // Min Value for Short
            // Implicit conversion from Short to Float
            Console.WriteLine("---------- Short Min to Float ----------");
            short shortMinValueE = short.MinValue;
            Single intValueE = shortMinValueE;
            Console.WriteLine("The minimum value for Short: {0}", shortMinValueE);
            Console.WriteLine("The type of intValueE: {0}", intValueE.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for Short
            // Implicit conversion from Short to Float
            Console.WriteLine("---------- Short Max to Float ----------");
            short shortMaxValueF = short.MaxValue;
            Single intValueF = shortMaxValueF;
            Console.WriteLine("The maximum value for Short: {0}", shortMaxValueF);
            Console.WriteLine("The type of intValueF: {0}", intValueF.GetTypeCode());    

            Console.WriteLine("\n");   

            // Min Value for Short
            // Implicit conversion from Short to Double
            Console.WriteLine("---------- Short Min to Double ----------");
            short shortMinValueG = short.MinValue;
            Double intValueG = shortMinValueG;
            Console.WriteLine("The minimum value for Short: {0}", shortMinValueG);
            Console.WriteLine("The type of intValueG: {0}", intValueG.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for Short
            // Implicit conversion from Short to Double
            Console.WriteLine("---------- Short Max to Double ----------");
            short shortMaxValueH = short.MaxValue;
            Double intValueH = shortMaxValueH;
            Console.WriteLine("The maximum value for Short: {0}", shortMaxValueH);
            Console.WriteLine("The type of intValueH: {0}", intValueH.GetTypeCode());    

            Console.WriteLine("\n");  

            // Min Value for Short
            // Implicit conversion from Short to Decimal
            Console.WriteLine("---------- Short Min to Decimal ----------");
            short shortMinValueI = short.MinValue;
            Decimal intValueI = shortMinValueI;
            Console.WriteLine("The minimum value for Short: {0}", shortMinValueI);
            Console.WriteLine("The type of intValueI: {0}", intValueI.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for Short
            // Implicit conversion from Short to Decimal
            Console.WriteLine("---------- Short Max to Decimal ----------");
            short shortMaxValueJ = short.MaxValue;
            Decimal intValueJ = shortMaxValueJ;
            Console.WriteLine("The maximum value for Short: {0}", shortMaxValueJ);
            Console.WriteLine("The type of intValueJ: {0}", intValueJ.GetTypeCode());    

            Console.WriteLine("\n"); 
        }
    }
}
