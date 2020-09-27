using System;

namespace _003_integral_numeric
{
    public class ushort_min_max
    {
        // displaying minimum value of ushort
        public void display_min_value_of_ushort()
        {
            ushort ushortMinValue = ushort.MinValue;
            Console.Write("The minimum value of ushort is: {0}", ushortMinValue);
            Console.WriteLine();
        }

        // displaying maximum value of short
        public void display_max_value_of_ushort()
        {
            ushort ushortMaxValue = ushort.MaxValue;
            Console.Write("The maximum value of ushort is: {0}", ushortMaxValue);
            Console.WriteLine();
        }
    }
}