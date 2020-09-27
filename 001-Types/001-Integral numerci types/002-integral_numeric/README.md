## Comparing the minimum and maxmimum value for the following integral numeric types to literal integer:
* sbyte
* byte
* short
* ushort
* int
* uint
* long
* ulong

### For example:
```c-sharp
// Checking if sbyteMinValue_a equals to sbyteMinValue_b
Console.WriteLine("---------- SByte Min Value Check ----------");
sbyte sbyteMinValue_a = sbyte.MinValue;
sbyte sbyteMinValue_b = -128;
if (sbyteMinValue_a == sbyteMinValue_b)
{
    Console.WriteLine("The minimum value of SByte property {0} equals to literal integer {1}. ", 
    sbyteMinValue_a, sbyteMinValue_b);
} 
else
{
    Console.WriteLine("The minimum value of SByte property {0} does not equal to literal integer {1}. ", 
    sbyteMinValue_a, sbyteMinValue_b);
}
Console.WriteLine("\n");
```
