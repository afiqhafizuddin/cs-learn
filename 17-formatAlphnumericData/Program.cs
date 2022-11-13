// Compossite Formatting
Console.WriteLine("\nComposite Formatting");
string first = "Hello";
string second = "World";

string result = string.Format("{0}, {1}!", first, second);
Console.WriteLine(result);
Console.WriteLine("{0} {0} {0}", first, second);

// String interpolation
Console.WriteLine("\nString Interpolation");
// String Interpolation is a newer technique that simplifies composite formatting.

Console.WriteLine($"{first}, {second}!");
Console.WriteLine($"{first} {first} {first}");
Console.WriteLine($"{second} {second} {second}");

// Formatting currency
Console.WriteLine("\nFormatting Currency");
decimal price = 123.45m;
int discount = 50;

Console.WriteLine($"Price {price:C} (save {discount:C})");

// code-culture: 5 character code to determine the region and language of the end users
// en-US, fr-FR, fr-CA, en-MY

// Formatting numbers
Console.WriteLine("\nFormatting Number");

decimal measurement = 123456.789m;
Console.WriteLine($"Measurement: {measurement:N3}");

// N numerical specifier only display 2 number afer decimal point

// Formatting percentage
Console.WriteLine("\nFormating Percentage");
decimal tax = .98765m;
Console.WriteLine($"Tax rate: {tax:P2}");

// Recap
// 1. Composite Formatting
// 2. String Interpolation 
// 3. Currrency Formatting, :C1, :C3 - number for precision
// 4. Number Formating, :N, :N3, etc
// 5. Percentage Formatting, :P, :P3
