using System.Text;
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int qoutient = 7 / 5;
Console.WriteLine($"Sum:{sum}");
Console.WriteLine($"Difference:{difference}");
Console.WriteLine($"Product:{product}");
Console.WriteLine($"Qoutient:{qoutient}");

// Add code to perform division using literal decimal data
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// Here are two additional examples that work equally well:
decimal decimalQuotient2 = 7 / 5.0m;
decimal decimalQuotient1 = 7.0m / 5.0m;
Console.WriteLine(decimalQuotient2 + decimalQuotient1);

// However, the following lines of code won't work (or give inaccurate results):
// int decimalQuotientA = 7 / 5.0m;
// int decimalQuotientB = 7.0m / 5;
// int decimalQuotientC = 7.0m / 5.0m;
// decimal decimalQuotientD = 7 / 5;
// Console.WriteLine(decimalQuotientA + decimalQuotientB + decimalQuotientC + decimalQuotientD);

// decimal numbers:
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

// Modulus:
Console.WriteLine($"Modulus of 200/5: {200 / 5}");
Console.WriteLine($"Modulus of 7/5: {7 / 5}");
// In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:

//1.Parentheses(whatever is inside the parenthesis is performed first)
//2.Exponents
//3.Multiplication and Division (from left to right)
//4.Addition and Subtraction (from left to right)

// Write code to exercise C#'s order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

// same same but different.
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;
Console.WriteLine(value); // value is now 10.

// The++ operator increments the value of the variable by 1
int value3 = 0;     // value is now 0.
value3 = value3 + 1; // value is now 1.
value3++; // value is now 2.
Console.WriteLine(value3);
