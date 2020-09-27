using System;

namespace _003_integral_numeric
{
    public class ulong_min_max
    {
        // displaying minimum value of ulong
        public void display_min_value_of_ulong()
        {
            ulong ulongMinValue = ulong.MinValue;
            Console.Write("The minimum value of ulong is: {0}", ulongMinValue);
            Console.WriteLine();
        }

        // displaying maximum value of ulong
        public void display_max_value_of_ulong()
        {
            ulong ulongMaxValue = ulong.MaxValue;
            Console.Write("The maximum value of ulong is: {0}", ulongMaxValue);
            Console.WriteLine();
        }        
    }
}