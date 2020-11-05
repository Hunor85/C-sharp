using System;

namespace bool008
{
    class Program
    {
        static void Main(string[] args)
        {
            // Returns Null
            bool? m()
            {
                Console.WriteLine("Hunor");
                return null;
            }

            // Returns True
            bool? t()
            {
                Console.WriteLine("Hunor");
                return true;   
            }

            // Returns False
            bool? d()
            {
                Console.WriteLine("Hunor");
                return false;
            }


            // Output: Hunor, null
            bool? v1 = true & m();
            Console.WriteLine(v1 is null ? "null" : v1.Value.ToString());

            Console.WriteLine("\n");

            // Output: Hunor, null
            bool? v2 = null & t();
            Console.WriteLine(v2 is null ? "null" : v2.Value.ToString());

            Console.WriteLine("\n");

            // Output: Hunor, False
            bool? v3 = false & m();
            Console.WriteLine(v3 is null ? "null" : v3.Value.ToString());

            Console.WriteLine("\n");

            // Output: Hunor, False
            bool? v4 = null & d();
            Console.WriteLine(v4 is null ? "null" : v4.Value.ToString());

            Console.WriteLine("\n");

            // Output: Hunor, null
            bool? v5 = null & m();
            Console.WriteLine(v5 is null ? "null" : v5.Value.ToString());

            Console.WriteLine("\n");

            // Output: Hunor, True
            bool? v6 = true | m();
            Console.WriteLine(v6 is null ? "null" : v6.Value.ToString());

            Console.WriteLine("\n");

            // Output: Hunor, True
            bool? v7 = null | t();
            Console.WriteLine(v7 is null ? "null" : v7.Value.ToString());

            Console.WriteLine("\n");

            // Output: Hunor, null
            bool? v8 = false | m();
            Console.WriteLine(v8 is null ? "null" : v8.Value.ToString());

            Console.WriteLine("\n");

            // Output: Hunor, null
            bool? v9 = null | d();
            Console.WriteLine(v9 is null ? "null" : v9.Value.ToString());

            Console.WriteLine("\n");

            // Output: Hunor, null
            bool? v10 = null | m();
            Console.WriteLine(v10 is null ? "null" : v10.Value.ToString());

            Console.WriteLine("\n");

        }
    }
}
