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
            // Implicit conversion from SByte to Short
            Console.WriteLine("---------- SByte Min ----------");
            sbyte sbyteMinValueA = sbyte.MinValue;
            short shortValueA = sbyteMinValueA;
            Console.WriteLine("The minimum value for SByte: {0}", sbyteMinValueA);
            Console.WriteLine("The type of shortValeuA: {0}", shortValueA.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for SByte
            // Implicit conversion from SByte to Short
            Console.WriteLine("---------- SByte Max ----------");
            sbyte sbyteMaxValueB = sbyte.MaxValue;
            short shortValueB = sbyteMaxValueB;
            Console.WriteLine("The maximum value for SByte: {0}", sbyteMaxValueB);
            Console.WriteLine("The type of shortValeuB: {0}", shortValueB.GetTypeCode());
            
            Console.WriteLine("\n");

            // Min Value for SByte
            // Implicit conversion from SByte to Int
            Console.WriteLine("---------- SByte Min ----------");
            sbyte sbyteMinValueC = sbyte.MinValue;
            int shortValueC = sbyteMinValueC;
            Console.WriteLine("The minimum value for SByte: {0}", sbyteMinValueC);
            Console.WriteLine("The type of shortValeuC: {0}", shortValueC.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for SByte
            // Implicit conversion from SByte to Int
            Console.WriteLine("---------- SByte Max ----------");
            sbyte sbyteMaxValueD = sbyte.MaxValue;
            int shortValueD = sbyteMaxValueD;
            Console.WriteLine("The maximum value for SByte: {0}", sbyteMaxValueD);
            Console.WriteLine("The type of shortValeuD: {0}", shortValueD.GetTypeCode());    

            Console.WriteLine("\n");

            // Min Value for SByte
            // Implicit conversion from SByte to Long
            Console.WriteLine("---------- SByte Min ----------");
            sbyte sbyteMinValueE = sbyte.MinValue;
            long shortValueE = sbyteMinValueE;
            Console.WriteLine("The minimum value for SByte: {0}", sbyteMinValueE);
            Console.WriteLine("The type of shortValeuE: {0}", shortValueE.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for SByte
            // Implicit conversion from SByte to Long
            Console.WriteLine("---------- SByte Max ----------");
            sbyte sbyteMaxValueF = sbyte.MaxValue;
            long shortValueF = sbyteMaxValueF;
            Console.WriteLine("The maximum value for SByte: {0}", sbyteMaxValueF);
            Console.WriteLine("The type of shortValeuF: {0}", shortValueF.GetTypeCode());    

            Console.WriteLine("\n");            

            // Min Value for SByte
            // Implicit conversion from SByte to Float
            Console.WriteLine("---------- SByte Min ----------");
            sbyte sbyteMinValueG = sbyte.MinValue;
            Single shortValueG = sbyteMinValueG;
            Console.WriteLine("The minimum value for SByte: {0}", sbyteMinValueG);
            Console.WriteLine("The type of shortValeuG: {0}", shortValueG.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for SByte
            // Implicit conversion from SByte to Float
            Console.WriteLine("---------- SByte Max ----------");
            sbyte sbyteMaxValueH = sbyte.MaxValue;
            Single shortValueH = sbyteMaxValueH;
            Console.WriteLine("The maximum value for SByte: {0}", sbyteMaxValueH);
            Console.WriteLine("The type of shortValeuH: {0}", shortValueH.GetTypeCode());    

            Console.WriteLine("\n");   

            // Min Value for SByte
            // Implicit conversion from SByte to Double
            Console.WriteLine("---------- SByte Min ----------");
            sbyte sbyteMinValueI = sbyte.MinValue;
            Double shortValueI = sbyteMinValueI;
            Console.WriteLine("The minimum value for SByte: {0}", sbyteMinValueI);
            Console.WriteLine("The type of shortValeuI: {0}", shortValueI.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for SByte
            // Implicit conversion from SByte to Double
            Console.WriteLine("---------- SByte Max ----------");
            sbyte sbyteMaxValueJ = sbyte.MaxValue;
            Double shortValueJ = sbyteMaxValueJ;
            Console.WriteLine("The maximum value for SByte: {0}", sbyteMaxValueJ);
            Console.WriteLine("The type of shortValeuJ: {0}", shortValueJ.GetTypeCode());    

            Console.WriteLine("\n");  

            // Min Value for SByte
            // Implicit conversion from SByte to Decimal
            Console.WriteLine("---------- SByte Min ----------");
            sbyte sbyteMinValueK = sbyte.MinValue;
            Decimal shortValueK = sbyteMinValueK;
            Console.WriteLine("The minimum value for SByte: {0}", sbyteMinValueK);
            Console.WriteLine("The type of shortValeuK: {0}", shortValueK.GetTypeCode());

            Console.WriteLine("\n");

            // Max Value for SByte
            // Implicit conversion from SByte to Decimal
            Console.WriteLine("---------- SByte Max ----------");
            sbyte sbyteMaxValueL = sbyte.MaxValue;
            Decimal shortValueL = sbyteMaxValueJ;
            Console.WriteLine("The maximum value for SByte: {0}", sbyteMaxValueL);
            Console.WriteLine("The type of shortValeuL: {0}", shortValueL.GetTypeCode());    

            Console.WriteLine("\n"); 
        }
    }
}
