using System;

namespace bool009
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output: True
            bool v1 = !true & false ^ true | false && true || false;
            Console.WriteLine(v1);

            Console.WriteLine("\n");

            // Output: False
            bool v2 = !true ^ false & true | false && true || false;
            Console.WriteLine(v2);

            Console.WriteLine("\n");

            // Output: False
            bool v3 = !true ^ false | true & false && true || false;
            Console.WriteLine(v3);

            Console.WriteLine("\n");

            // Output: False
            bool v4 = !true ^ false | true && false & true || false;
            Console.WriteLine(v4);

            Console.WriteLine("\n");

            // Output: False
            bool v5 = !true ^ false | true && false || true & false;
            Console.WriteLine(v5);

            Console.WriteLine("\n");

            // Output: False
            bool v6 = true ^ !false & true && false | true || false;
            Console.WriteLine(v6);

            Console.WriteLine("\n");

        }
    }
}
