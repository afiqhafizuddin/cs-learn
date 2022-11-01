// Evaluate Boolean expressions to make decisions in C#
using System.Diagnostics;

Console.WriteLine("\nStep 1");
// Step 1: using string equality  operator

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine( myValue == "a");

Console.WriteLine("\nStep 2");
// Step 2: Improve the checking by using string's built-in helper methods

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("\nStep 3");
// Step 3: Use the inequality opeator

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

Console.WriteLine(myValue != "a");

Console.WriteLine("\nStep 4");
// Step 4: Using the comaprison operator

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 >= 1);


// Methods that return Boolean value
Console.WriteLine("\nStep 5");
// Step 5: Use method invocation expression
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Console.WriteLine("\nStep 6");
// Step 6: Use logical negation operator
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));