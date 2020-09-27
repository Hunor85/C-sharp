using System;

namespace _003_integral_numeric
{
    public class byte_min_max
    {
        // displaying minimum value of byte
        public void display_min_value_of_byte()
        {
            byte byteMinValue = byte.MinValue;
            Console.Write("The minimum value of byte is: {0}", byteMinValue);
            Console.WriteLine();
        }

        // displaying maximum value of byte
        public void display_max_value_of_byte()
        {
            byte byteMaxValue = byte.MaxValue;
            Console.Write("The maximum value of byte is: {0}", byteMaxValue);
            Console.WriteLine();
        }
    }
}