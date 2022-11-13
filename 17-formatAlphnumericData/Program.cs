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

// Challenge -----------------------------------------------------------------------------------------------------

string customerName = "Mr. Jones"; // greetings


string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"{customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"\nCurrenly, you own {currentShares} shares at a return of {currentReturn:P2}.");
Console.WriteLine($"\nAs our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential return would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
Console.WriteLine("1234567890123456789012345678901234567890123456789012345678901234567890");
Console.WriteLine(currentProduct + $"{currentReturn:P2}".PadLeft(15) + $"{currentProfit:C}".PadLeft(20));
Console.WriteLine(newProduct + $"{newReturn:P2}".PadLeft(11) + $"{newProfit:C}".PadLeft(20));

Console.WriteLine("\n" + currentProduct.PadRight(20) + $"{currentReturn:P2}" + $"{currentProfit:C}".PadLeft(20));
Console.WriteLine(newProduct.PadRight(20) + $"{newReturn:P2}" + $"{newProfit:C}".PadLeft(20));


// another solution

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine($"\n{comparisonMessage}");