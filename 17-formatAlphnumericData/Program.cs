// Compossite Formatting
using System.Security.Principal;

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


// String interpolation
Console.WriteLine("\nString Interplation Exercises");
int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
Console.WriteLine($"      Subtotal: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Due: {total:C}");

// padding & allignment
Console.WriteLine("\nPadding & Alignment");

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));

// overloaded methods - takes additional args

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '+'));

// working with padded strings
Console.WriteLine("\nPadded Strings Exercises");
string paymentID = "789";
string payeeName = "Mr. Stephen Ortega";
string paymentAmpount = "RM5,000.00"; 

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmpount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);