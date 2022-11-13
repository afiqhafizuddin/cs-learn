// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// VARIABLES IN C#

// Value assignment to a variable
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

string anothername = "Afiq Hafizuddin Bin Zainal";
Console.WriteLine(anothername);

// Reassign the value of variable
firstName = "Betty";
anothername = "Jamiah";
Console.WriteLine(firstName + ' ' + anothername); // concat

// initializing the variable
// it is recommended to set the value of a variable as soon as you declare it
string initializingVariable = "see what i mean????";
Console.WriteLine(initializingVariable);

// IMPLICITLY TYPED LOCAL VARIABLES
// created by using "var" keyword - intructs the C# compiler to infer the type

var message = "Hello, World";
Console.WriteLine(message);
message = "C# is my favourite language";
Console.WriteLine(message);

/*
Notes - in C#, the variable is statically typed by the compiler, regardless if using the actual data type or
allow the compiler to infer the data. 

Type is locked at the time of declaration, and therefore will never be able to hold values of different data type
*/

/* 
"var" keyword has an important use in C#. For reasons that may not be clear until advanced code. 

it is recommended to use actual data type. Using actual data type helps to be purposeful when writing code
 
*/

// CHALLENGE

string name = "Bob";
int message1 = 3;
double temp = 34.4;

Console.WriteLine("Hello, " + name + "! You have " + message1 + " messages in your box. The temperatuere is " + temp + " celsius.");

// STRING FORMATTING IN C#
/* In C#, escape character sequence starts with backlash "/" and followed by special characters
 * 
 * 
 */

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");


// to put double quotation inside string
Console.WriteLine("Hello \"World\"!");

// To display path 
Console.WriteLine("C:\\source\\repos");

// Creating mockup of command line 
Console.WriteLine("Generating Invoices for Customer \"ABC\" ....\n");
Console.WriteLine("Invoice: 1021\t\tCompleted!");
Console.WriteLine("Invoice: 1022\t\tCompleted!");
Console.WriteLine("\nOutput Directory:\t");

// Verbatim String Literal 

/*  keep all whitespace and characters without the need to escape the backslash.
 *  
 *  
 */

Console.WriteLine(@"    c:\source\repos
        (""This is where your code goes"")");

Console.WriteLine(@"c:\source\repos");


// Unicode escape characters

// testing autosave feature on Visual Studio 2022

Console.WriteLine("This is to test the autosave feature Visual Studio 2022");
Console.WriteLine("Test again!");

// String Concatenation

string namaPertama = "Bob";
string greeting = "Hello";

string text = greeting + " " + namaPertama + "!";
Console.WriteLine(text);

// Using intermediate variable. Should be avoided unless there is solid reason 

// avoid using intermediate variables by performing the concatenation operation as you need it.

Console.WriteLine(greeting + " " + namaPertama + "!");

// String Concatenation

// String concatenation allows you to combine smaller literal and variable strings into a single string. 
// Avoid creating intermediate variables if adding them doesn't increase readability


// String Interpolation

// String interpolation combines multiple values into a single literal string by using a "template"
// and one or more interpolation expressions. An interpolation expression is a variable surrounded by an
// opening and closing curly brace symbol { }.
// The literal string becomes a template when it's prefixed by the $ character.

string text1 = $"{greeting} {namaPertama}!";
Console.WriteLine(text1);

// combining verbatim literals and string concat

string projectName = "Console-App";
Console.WriteLine($@"C:\Output\{projectName}\Data");


// String interpolation provides an improvement over string concatenation by reducing
// the number of characters required in some situations.

// You can combine string interpolation and verbatim literals by combining the
// symbols for each and using that as a prefix for the string template.


// Challenge

string newProjectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English Output:\n\tc:\\Exercise\\{newProjectName}\\datat.txt\n");
Console.WriteLine($@"{russianMessage}:
    c:\Execise\{newProjectName}\ru-RU\data.txt");



















