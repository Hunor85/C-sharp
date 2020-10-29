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
        }
    }
}
