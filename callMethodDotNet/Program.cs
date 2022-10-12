// Call methods from the .NET class library using C#


// introduction

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

