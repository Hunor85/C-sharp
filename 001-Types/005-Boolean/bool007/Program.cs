using System;

namespace bool007
{
    class Program
    {
        static void Main(string[] args)
        {

            // Output: True
            bool v1 = true;
            v1 &= true;
            Console.WriteLine(v1);

            // Output: False
            bool v2 = true;
            v2 &= false;
            Console.WriteLine(v2);

            // Output: False
            bool v3 = false;
            v3 &= true;
            Console.WriteLine(v3);

            // Output: False
            bool v4 = false;
            v4 &= false;
            Console.WriteLine(v4);

            // Output: True
            bool v5 = true;
            v5 |= true;
            Console.WriteLine(v5);

            // Output: True
            bool v6 = true;
            v6 |= false;
            Console.WriteLine(v6);

            // Output: True
            bool v7 = false;
            v7 |= true;
            Console.WriteLine(v7);

            // Output: False
            bool v8 = false;
            v8 |= false;
            Console.WriteLine(v8);

            // Output: False
            bool v9 = true;
            v9 ^= true;
            Console.WriteLine(v9);

            // Output: True
            bool v10 = true;
            v10 ^= false;
            Console.WriteLine(v10);

            // Output: True
            bool v11 = false;
            v11 ^= true;
            Console.WriteLine(v11);

            // Output: False
            bool v12 = false;
            v12 ^= false;
            Console.WriteLine(v12);

        }
    }
}
