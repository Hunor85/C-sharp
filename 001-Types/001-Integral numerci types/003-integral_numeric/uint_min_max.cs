using System;

namespace _003_integral_numeric
{
    public class uint_min_max
    {
        // displaying minimum value of uint
        public void display_min_value_of_uint()
        {
            uint uintMinValue = uint.MinValue;
            Console.Write("The minimum value of uint is: {0}", uintMinValue);
            Console.WriteLine();
        }

        // displaying maximum value of uint
        public void display_max_value_of_uint()
        {
            uint uintMaxValue = uint.MaxValue;
            Console.Write("The maximum value of uint is: {0}", uintMaxValue);
            Console.WriteLine();
        }
    }
}