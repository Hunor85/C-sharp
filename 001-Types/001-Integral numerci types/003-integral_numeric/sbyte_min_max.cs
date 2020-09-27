using System;

namespace _003_integral_numeric
{
    public class sbyte_min_max
    {
        // displaying minimum value of sbyte
        public void display_min_value_of_sbyte()
        {
            sbyte sbyteMinValue = sbyte.MinValue;
            Console.Write("The minimum value of sbyte is: {0}", sbyteMinValue);
            Console.WriteLine();
        }

        // displaying maximum value of sbyte
        public void display_max_value_of_sbyte()
        {
            sbyte sbyteMaxValue = sbyte.MaxValue;
            Console.Write("The maximum value of sbyte is: {0}", sbyteMaxValue);
            Console.WriteLine();
        }
    }
}