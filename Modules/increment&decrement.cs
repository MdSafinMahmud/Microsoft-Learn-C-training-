// Write code to increment and decrement a value
int value = 1;
value = value + 1;
Console.WriteLine("First increment: " + value);
value += 1;
Console.WriteLine("Second increment: " + value);
value++;
Console.WriteLine("Third increment: " + value);
value = value - 1;
Console.WriteLine("First decrement: " + value);
value -= 1;
Console.WriteLine("Second decrement: " + value);
value--;
Console.WriteLine("Third decrement: " + value);

// another ways
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// Here's what you've learned so far about mathematical operations in C#:

// Use compound assignment operators like +=, -=, *=, ++, and --to perform a mathematical operation like increment or decrement, then assign the result into the original variable.
// Increment and decrement operators perform differently depending on whether the operator is before or after the operand.
