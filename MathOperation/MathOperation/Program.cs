// Performing Basic Math Operation in C#

// Learning Objectives

/*  Perform mathematical operations on numeric values
 *  Observe implicit type conversion between strings and numeric values
 *  Temporarily convert one data type into another 
 */

int firstNum = 12;
int secondNum = 13;

Console.WriteLine(firstNum + secondNum);

// Mix data types to force implicit type conversions

string firstName = "Bob";
int widgetsSold = 58;

Console.WriteLine(firstName + " sold " + widgetsSold + " widgets");

// In this case, the C# compiler understands that we want to
// use the + symbol to concatenate the two operands. It deduces this because
// the + symbol is surrounded by operands of string and int data types.

// C# compiler will help if whenever possible. But ideally, a programmer must be explicit about intentions

// Advance case of concatenating and adding number
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets "); // adding parentheses to be clearer of our intentions. C# compiler understands it as the addition operation of two ints, 
// rather than adding it all togehter like the previous example without parentheses
// () - overloaded operator. We want C# compiler to solve operation inside the parentheses first. 

// Recap

/*  You can perform mathematical-like addition operations on numbers.
 *  
 *  Both string concatenation and addition use the plus + symbol. 
 *  This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
 
 *  When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying to 
 *  concatenate the string representation of a number for presentation purposes.

 *  You can use parentheses to define an order of operations to explicitly tell the compiler that you want to 
 *  perform certain operations before other operations.

 */


// Math Operation

int sum = 5 + 7;
int difference = 7 - 5;
int product = 5 * 7;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// using decimal data type

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal Quotient: " + decimalQuotient);

// alternative 
decimal decimalQuotient1 = 7 / 5.0m;
decimal decimalQuotient2 = 7.0m / 5.0m;

Console.WriteLine(decimalQuotient1);
Console.WriteLine(decimalQuotient2);

// inaccurate example

/*
int decimalQuotient = 7 / 5.0m;
int decimalQuotient = 7.0m / 5;
int decimalQuotient = 7.0m / 5.0m;
decimal decimalQuotient = 7 / 5;
*/

// Performing addition using literal decimal data

decimal Quotient = (decimal)firstNum / (decimal)secondNum;
Console.WriteLine(Quotient);

// Three uses, or overloads for the parenthesis operator: 
// Method invocation, order of operations and type casting 

// To determine remainder after int division 

Console.WriteLine("Modulus of 200 / 5: " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5: " + (7 %5 ));

// C# follows the same PEMDAS convention except for exponents
// although there is no exponents operator in C#, can use System.Math.Pow() method, available from .NET Class Library

// to exercise C#'s order of operation

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;

Console.WriteLine(value1);
Console.WriteLine(value2);














