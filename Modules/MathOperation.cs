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

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);