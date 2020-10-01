# Integer literals

Integer literals can be decimal without any prefix. For example:
```c#
var decimalLiteral = 42L; // L or l are both correct 
```
If the literal is suffixed by L or l, its type is the first of the following types in which its value can be represented: long, ulong.

The following diagram gives a visual representation for literals without suffix with their corresponding types in which they can be represented:

![Integer literal](https://github.com/Hunor85/C-sharp/blob/master/001-Types/001-Integral%20numerci%20types/006-integer_literal/docs/inetger%20literal.png)

For example:
- if the literal is within -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807 the type will be Int64

