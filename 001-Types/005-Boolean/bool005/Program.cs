using System;

namespace bool005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output: True
            bool v1 = true || true;
            Console.WriteLine(v1);

            Console.WriteLine("\n");

            // Output: True
            bool v2 = true || false;
            Console.WriteLine(v2);

            Console.WriteLine("\n");

            // Output: False
            bool v3 = false || false;
            Console.WriteLine(v3);

            Console.WriteLine("\n");

            // Output: True
            bool v4 = false || true;
            Console.WriteLine(v4);
            
            Console.WriteLine("\n");

            Console.WriteLine("------------------------------------------------");

            bool RightOperandTrue()
            {
                Console.WriteLine("Second operand");
                return true;
            }

            bool RightOperandFalse()
            {
                Console.WriteLine("Second operand");
                return false;
            }

            // Output: True 
            bool v5 = true || RightOperandTrue();
            Console.WriteLine(v5);

            Console.WriteLine("\n");

            // Output: True
            bool v6 = true || RightOperandTrue();
            Console.WriteLine(v6);

            Console.WriteLine("\n");

            // Output: Second operand, True
            bool v7 = false || RightOperandTrue();
            Console.WriteLine(v7);

            Console.WriteLine("\n");

            // Output: Second operand, False
            bool v8 = false || RightOperandFalse();
            Console.WriteLine(v8);

            Console.WriteLine("\n");
        }
    }
}
