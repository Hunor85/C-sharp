using System;

namespace _003_integral_numeric
{
    public class long_min_max
    {
        // displaying minimum value of long
        public void display_min_value_of_long()
        {
            long longMinValue = long.MinValue;
            Console.Write("The minimum value of long is: {0}", longMinValue);
            Console.WriteLine();
        }

        // displaying maximum value of long
        public void display_max_value_of_long()
        {
            long longMaxValue = long.MaxValue;
            Console.Write("The maximum value of long is: {0}", longMaxValue);
            Console.WriteLine();
        }
    }
}