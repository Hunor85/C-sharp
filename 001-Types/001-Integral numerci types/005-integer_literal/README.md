# Integer literals

If the literal is suffixed by U or u, its type is the first of the following types in which its value can be represented: uint, ulong.
For example:
```c#
var decimalLiteral = 42u; // U or u are both correct 
```

The following diagram gives a visual representation for literals with U or u suffix and with their corresponding types in which they can be represented:

![Integer literal](https://github.com/Hunor85/C-sharp/blob/master/001-Types/001-Integral%20numerci%20types/005-integer_literal/docs/inetger%20literal.png)

For example:
- if the literal is within -9,223,372,036,854,775,808 and -1 the type will be Int64
- if the literal is within 0 and 4,294,967,295 the type will be UInt32
