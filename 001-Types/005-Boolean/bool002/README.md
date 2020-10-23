## Conditional logical AND operator &&
The conditional logical AND operator &&, also known as the "short-circuiting" logical AND operator, computes the logical AND of its operands. 
The result of x && y is true if both x and y evaluate to true. Otherwise, the result is false. 
If x evaluates to false, y is not evaluated.

So:
x && y | result
--- | --- 
TRUE & TRUE | TRUE
TRUE & FALSE | FALSE
FALSE & FALSE | FALSE
FALSE & TRUE | FALSE

[Link](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators) to Official Docs
