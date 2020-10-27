using System;

namespace bool003
{
    class Program
    {
        static void Main(string[] args)
        {
            // v1 = false
            bool v1 = true ^ true;
            Console.WriteLine("v1 {0}", v1);

            // v2 = true
            bool v2 = true ^ false;
            Console.WriteLine("v2 {0}",v2);

            // v3 = false
            bool v3 = false ^ false;
            Console.WriteLine("v3 {0}",v3);

            // v4 = true
            bool v4 = false ^ true;
            Console.WriteLine("v4 {0}",v4);

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

            // v5 = false
            bool v5 = true ^ RightOperandTrue();
            Console.WriteLine("v5 {0}",v5);

            // v6 = true
            bool v6 = true ^ RightOperandFalse();
            Console.WriteLine("v6 {0}",v6);

            // v7 = false
            bool v7 = false ^ RightOperandFalse();
            Console.WriteLine("v7 {0}", v7);

            // v8 = 
            bool v8 = false ^ RightOperandTrue();
            Console.WriteLine("v8 {0}",v8);
        }
    }
}
