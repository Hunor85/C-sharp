using System;

namespace _003_integral_numeric
{
    public class short_min_max
    {
        // displaying minimum value of short
        public void display_min_value_of_short()
        {
            short shortMinValue = short.MinValue;
            Console.Write("The minimum value of short is: {0}", shortMinValue);
            Console.WriteLine();
        }

        // displaying maximum value of short
        public void display_max_value_of_short()
        {
            short shortMaxValue = short.MaxValue;
            Console.Write("The maximum value of short is: {0}", shortMaxValue);
            Console.WriteLine();
        }
    }
}