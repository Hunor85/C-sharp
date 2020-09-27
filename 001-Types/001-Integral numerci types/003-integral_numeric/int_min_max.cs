using System;

namespace _003_integral_numeric
{
    public class int_min_max
    {
        // displaying minimum value of int
        public void display_min_value_of_int()
        {
            int intMinValue = int.MinValue;
            Console.Write("The minimum value of int is: {0}", intMinValue);
            Console.WriteLine();
        }

        // displaying maximum value of int
        public void display_max_value_of_int()
        {
            int intMaxValue = int.MaxValue;
            Console.Write("The maximum value of int is: {0}", intMaxValue);
            Console.WriteLine();
        }
    }
}