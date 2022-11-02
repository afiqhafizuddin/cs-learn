using System;
using MyNewApp.Utilitites;
// 3 levels of code blocks: a method Main(); a class Program; a namespace MyNewApp 
namespace MyNewApp // should be same as project's name
{
    
    // calling a method from the same class
    class Program // containers for methods, properties, events and fields
    {
        static void Main(string[] args) // Main() method is special, .NET Runtime search by default, as it's an entry point to execute the program.
        {
            string  value = "Microsoft Learn";
            string reversedVal = Utility.Reverse(value); // calling a class of diff namespace: Namespace.Class.Method
            Console.WriteLine($"Secret Message: {reversedVal}");
        }
        /*
        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        } */
    } 
}

    // Calling a method in a different class
    /*
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn & Google Developer Center";
            string reversedVal = Utilities.Reverse(value);
            Console.WriteLine($"Secret Message: {reversedVal}");

        }
    }

    class Utilities
    {
        public static string Reverse(string message)
        {
            char[] letters1 = message1.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }

} */

// child-namespace

// referenecing class in a different namespace
namespace MyNewApp.Utilitites
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

namespace MyNewApp.Business
{
    // CLasses Here
}

namespace MyNewApp.Data
{
    // Classes Here
}

// Recap and Summary

// Code blocks define the boundaries of higher-level structures like namespaces, classes, and methods.
// These boundaries require consideration because they affect the visibility of both variables and other larger structures like methods and clasess
// additional keyword i.e. 'public' and 'using' must be used to pass into the boundaries of another code blocks.
