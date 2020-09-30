# Integer literals

Integer literals can be decimal without any prefix. For example:
```c#
var decimalLiteral = 42; 
```
If the literal is suffixed by U or u, its type is the first of the following types in which its value can be represented: uint, ulong.

The following diagram gives a visual representation for literals without suffix with their corresponding types in which they can be represented:

![Integer literal](https://github.com/Hunor85/C-sharp/blob/master/001-Types/001-Integral%20numerci%20types/005-integer_literal/docs/inetger%20literal.png)

For example:
- if the literal is within -2,147,483,648 and -1 the type will be Int64
- if the literal is within 0 and 4,294,967,295 the type will be Int32
