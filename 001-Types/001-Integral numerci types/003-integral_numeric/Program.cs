using System;

namespace _003_integral_numeric
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            sbyte_min_max sbyteMinMax = new sbyte_min_max();
            byte_min_max byteMinMax = new byte_min_max();
            short_min_max shortMinMax = new short_min_max();
            ushort_min_max ushortMinMax = new ushort_min_max();
            int_min_max intMinMax = new int_min_max();
            uint_min_max uintMinMax = new uint_min_max();
            long_min_max longMinMax = new long_min_max();
            ulong_min_max ulongMinMax = new ulong_min_max();

            while (true)
            {
                Console.WriteLine("1. Display minimum value of sbyte.");
                Console.WriteLine("2. Display maximum value of sbyte.");
                Console.WriteLine("3. Display minimum value of byte.");
                Console.WriteLine("4. Display maximum value of byte.");
                Console.WriteLine("5. Display minimum value of short.");
                Console.WriteLine("6. Display maximum value of short.");
                Console.WriteLine("7. Display minimum value of ushort.");
                Console.WriteLine("8. Display maximum value of ushort.");
                Console.WriteLine("9. Display minimum value of int.");
                Console.WriteLine("10. Display maximum value of int.");
                Console.WriteLine("11. Display minimum value of uint.");
                Console.WriteLine("12. Display maximum value of uint.");
                Console.WriteLine("13. Display minimum value of long.");
                Console.WriteLine("14. Display maximum value of long.");
                Console.WriteLine("15. Display minimum value of ulong.");
                Console.WriteLine("16. Display maximum value of ulong.");
                
                Console.WriteLine("17. Quit");

                Console.WriteLine("Enter youc choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 17)
                    break;

                switch (choice)
                {
                    case 1: 
                        sbyteMinMax.display_min_value_of_sbyte();
                        break;
                    case 2: 
                        sbyteMinMax.display_max_value_of_sbyte();
                        break;
                    case 3:
                        byteMinMax.display_min_value_of_byte();
                        break;
                    case 4:
                        byteMinMax.display_max_value_of_byte();
                        break;
                    case 5:
                        shortMinMax.display_min_value_of_short();
                        break;
                    case 6:
                        shortMinMax.display_max_value_of_short();
                        break;
                    case 7:
                        ushortMinMax.display_min_value_of_ushort();
                        break;
                    case 8:
                        ushortMinMax.display_max_value_of_ushort();
                        break; 
                    case 9:
                        intMinMax.display_min_value_of_int();
                        break;
                    case 10:
                        intMinMax.display_max_value_of_int();
                        break; 
                    case 11:
                        uintMinMax.display_min_value_of_uint();
                        break;
                    case 12:
                        uintMinMax.display_max_value_of_uint();
                        break;  
                    case 13:
                        longMinMax.display_min_value_of_long();
                        break;
                    case 14:
                        longMinMax.display_max_value_of_long();
                        break;   
                    case 15:
                        ulongMinMax.display_min_value_of_ulong();
                        break;
                    case 16:
                        ulongMinMax.display_max_value_of_ulong();
                        break; 
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");
        }
    }
}
