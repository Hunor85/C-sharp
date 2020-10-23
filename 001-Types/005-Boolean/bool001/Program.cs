using System;

namespace bool001
{
    class Program
    {
        static void Main(string[] args)
        {
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

            bool v1 = true & RightOperandTrue();
            Console.WriteLine(v1);

            Console.WriteLine("\n");

            bool v2 = true & RightOperandFalse();
            Console.WriteLine(v2);

            Console.WriteLine("\n");

            bool v3 = false & RightOperandTrue();
            Console.WriteLine(v3);

            Console.WriteLine("\n");

            bool v4 = false & RightOperandFalse();
            Console.WriteLine(v4);
            
            Console.WriteLine("\n");
        }
    }
}
