## Displaying the minimum and maxmimum value for the following integral numeric types with switch() statement:
* sbyte
* byte
* short
* ushort
* int
* uint
* long
* ulong

### For example:
```c#
// sbyte_min_max.cs
// displaying minimum value of sbyte
public void display_min_value_of_sbyte()
{
    sbyte sbyteMinValue = sbyte.MinValue;
    Console.Write("The minimum value of sbyte is: {0}", sbyteMinValue);
    Console.WriteLine();
}

// Program.cs
switch (choice)
{
    case 1: 
        sbyteMinMax.display_min_value_of_sbyte();
        break;

```
