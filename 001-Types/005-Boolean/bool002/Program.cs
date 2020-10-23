using System;

namespace bool002
{
    class Program
    {
        static void Main(string[] args)
        {
            bool v1 = true && true;
            Console.WriteLine(v1);

            Console.WriteLine("\n");

            bool v2 = true && false;
            Console.WriteLine(v2);

            Console.WriteLine("\n");
            
            bool v3 = false && false;
            Console.WriteLine(v3);

            Console.WriteLine("\n");

            bool v4 = false && true;
            Console.WriteLine(v4);

            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------");
           
            bool RightOperandTrue()
            {
                Console.WriteLine("Right operand with TRUE is evaluated.");
                return true;
            }

            bool RightOperandFalse()
            {
                Console.WriteLine("Right operand with FALSE is evaluated.");
                return false;
            }

            bool v5 = true && RightOperandTrue();
            Console.WriteLine(v5);

            Console.WriteLine("\n");

            bool v6 = true && RightOperandFalse();
            Console.WriteLine(v6);

            Console.WriteLine("\n");

            bool v7 = false && RightOperandTrue();
            Console.WriteLine(v7);

            Console.WriteLine("\n");

            bool v8 = false && RightOperandFalse();
            Console.WriteLine(v8);

            Console.WriteLine("\n");

        }
    }
}
