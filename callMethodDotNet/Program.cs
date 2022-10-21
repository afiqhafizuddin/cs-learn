// Call methods from the .NET class library using C#


// Introduction

// takes more than just the language itself to build apps
// need .NET runtime - hosts and manages codes as it executes 
// rely on a collection of functionalities called the .NET Class Library

// The .NET Class Library
// The .NET Class Library is a collection of thousands of classes containing tens of thousands of methods.
// These methods are created by Microsoft and are available for use in your applications. 

// A class is simply a container for methods. Developers typically keep related methods together in a single class.
// For example, any methods that can send or receive information from a command-line window are collected into the
// System.Console class in the .NET Class Library.


// Classes and methods let you build a specific type of application. 
// For example, one of the larger subsets of classes and methods allows you to create dynamic web applications
// There's several families of classes that allow you to build native desktop applications. Another subset of classes and methods lets you access a database.


// Calling a different kinds of methods in the .NET Class Library

Random dice = new Random(); // Random is a method, belongs to System.Random
int roll = dice.Next(1, 7); // Next method passing in two parameters: Min and Max val. and Next() method passing the value and we store in 'roll' variable
Console.WriteLine(roll); // 


// Stateless vs Stateful Methods

// Stateless Methods: Does not rely on or referencing or changing any values stores in memory
// aka Static Methods
// e.g. Console.WriteLine() doesn't rely on any stored values in memory

// Stateful Methods: built in such a way that they relied on values stored in memory by prev lines of code
// that have already executed.
// Stateful (instance) methods keep track of their state in fields, which are variables defined on the class
// Each new instance of the class gets its own copy of these fields in which to store state

// Creating new instance of a class 

Random newDice = new Random(); // an instance of a class is called an object. Use 'new' operator to create new instance of a class
                               // In above lines, operator 'new' creates new object called dice. 

// 'new' operator does few important things

// 1. Requests an address in the computer memory large enough to store new object based on on the Random class
// 2. Creates new object and stores it at the memory address
// 2. Returns the memory address so that it can saved in the 'dice' variable


// Recap 
// To call a methods of class in the .NET Class Library - use format ClassName.MethodName() 
// the symbol '.' is the member access operator to access a method defined on the class and '()' symbol
// is the method invocation operators

// Calling stateless methods doesn't require creating new instance of its class 
// 'new' operator to create an instance and an instance is called object

// Methods that dont return values when they finished - 'Void methods' 

// Console.WriteLine("Afiq Hafizuddin"); 
// Console.WriteLine("I love C#");

// Work with return values and input parameters

// Input Parameters

// Some methods are desiged to accept no input parameters, others are designed to accept input(s)

// When calling methods, separate each input with ',' 
int _roll = dice.Next(58, 80);
Console.WriteLine(_roll);

// OVerloaded methods

// Many methods in .NET Class Library have overloaded method signatures

// Console.WriteLine() has 19 different overloaded versions

int number = 7;
string numText = "seven";
System.Console.WriteLine(number);
System.Console.WriteLine();
System.Console.WriteLine(numText);


Random _dice = new Random();
int roll1 = _dice.Next();
int roll2 = _dice.Next(101);
int roll3 = _dice.Next(50, 200);

System.Console.WriteLine("First Roll: " + roll1);
System.Console.WriteLine("Second Roll: " + roll2);
System.Console.WriteLine("Third Roll: " + roll3);






