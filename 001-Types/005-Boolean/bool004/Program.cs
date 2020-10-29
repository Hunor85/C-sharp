using System;

namespace bool004
{
    // Conditional logical AND operator &&
    class Program
    {
        static void Main(string[] args)
        {
            // v1 = true
            bool v1 = true && true;
            Console.WriteLine(v1);

            // v2 = false
            bool v2 = true && false;
            Console.WriteLine(v2);

            // v3 = false
            bool v3 = false && false;
            Console.WriteLine(v3);

            // v4 = false
            bool v4 = false && true;
            Console.WriteLine(v4);

            bool RightOperandTrue()
            {
                Console.WriteLine("Right operand");
                return true;
            }

            bool RightOperandFalse()
            {
                Console.WriteLine("Right operand");
                return false;
            }

            // Output: Right operand, True
            // v5 = true
            bool v5 = true && RightOperandTrue();
            Console.WriteLine(v5);

            // Output: Right operand, False
            // v6 = false
            bool v6 = true && RightOperandFalse();
            Console.WriteLine(v6);

            // Output: False
            // v7 = false
            bool v7 = false && RightOperandFalse();
            Console.WriteLine(v7);

            // Output: 
            // v8 = 
            bool v8 = false && RightOperandTrue();
            Console.WriteLine(v8);
        }
    }
}
