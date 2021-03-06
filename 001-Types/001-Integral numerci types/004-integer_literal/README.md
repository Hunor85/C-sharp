# Integer literals

Integer literals can be decimal without any prefix. For example:
```c#
var decimalLiteral = 42; 
```
If the literal has no suffix, its type is the first of the following types in which its value can be represented: int, uint, long, ulong.
The following table shows the types in which different literal values can be represented:
![Integer literal](https://github.com/Hunor85/C-sharp/blob/master/001-Types/001-Integral%20numerci%20types/004-integer_literal/docs/integer%20literal%20b.png)


The following diagram gives a visual representation for literals without suffix with their corresponding types in which they can be represented:

![Integer literal 2](https://github.com/Hunor85/C-sharp/blob/master/001-Types/001-Integral%20numerci%20types/004-integer_literal/docs/inetger%20literal.png)

For example:
- if the literal is within -2,147,483,648 and 2,147,483,647 the type will be Int32
- if the literal is within -9,223,372,036,854,775,808 and -2,147,483,649 the type will be Int64
