using System;

namespace bool006
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool? n = null;

            bool? v1 = true ^ null;
            Console.WriteLine(v1);
            Console.WriteLine(v1 is null ? "null" : v1.Value.ToString());

            bool? v2 = null ^ true;
            Console.WriteLine(v2);
            Console.WriteLine(v2 is null ? "null" : v2.Value.ToString());


            bool? v3 = false ^ null;
            Console.WriteLine(v3);
            Console.WriteLine(v3 is null ? "null" : v3.Value.ToString());


            bool? v4 = null ^ false;
            Console.WriteLine(v4);
            Console.WriteLine(v4 is null ? "null" : v4.Value.ToString());

        }
    }
}
