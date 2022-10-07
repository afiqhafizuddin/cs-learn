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
Notes - in C#, the variable is statically typed by the compiler, regrardless if using the actual data type or
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
Console.WriteLine("Afiq Hafizuddin Bin Zainal");














