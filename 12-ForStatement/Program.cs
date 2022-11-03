// For Statement

// For: iterates thru a code block a specific number of times. 
// Foreach: iterates thru a code block once for each item in a seq. of data i.e. array or collection
// While: iterates thru a code block until a condition is met

// For: gives the dev much more control over the process of iteration by exposing the conditions for iteration


// Step 1: Basic of For statement

using System.Runtime.ExceptionServices;

for (int i = 0; i < 10; i++) // for keyword; set of parenthesis, contains 3 distinct parts, separated by semi-colon
    // 1st part: int i = 0; iterator variable
    // 2nd part: i < 10; iterator completion condition
    // 3rd part: action to take after every iteration
    // code block: as the body of the for statement
{
    Console.WriteLine(i);
}

int total = 0;
for (int num = 0; num < 1000; num += 10)
{
    Console.WriteLine(num);
}