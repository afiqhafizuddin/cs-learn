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

for (int num = 0; num < 100; num += 10)
{
    Console.WriteLine(num);
}

// Unique qualities of for statement
// 1. when the number of iterations of a code block is known 
// 2. allows to control the way in which each iteration is handled

// Step 2: Change the iteration condition

for (int j = 100; j >= 0; j--)
{
    Console.WriteLine(j);
}

// Step 3: Tinkering with the iterator's pattern
for (int x = 0; x < 10; x += 2)
{
    Console.WriteLine(x);
}

// Step 4: Use break keyword to break the iteration statement
for (int count= 0; count < 10; count++)
{
    Console.WriteLine(count);
    if (count == 7) break;
}

//  Step 5: Loop thru an array

string[] names = { "Alex", "Eddie", "David", "Michael"};
for (int iterator = names.Length - 1; iterator >= 0; iterator--) // iterates backward and 0-based indexing
{
    Console.WriteLine(names[iterator]);
}


// Step 6: Limitation of foreach statement
/*
foreach (var name in names)
{
    if (name == "David") name = "Sammy";
}
*/

// Step 7: overccoming the foreach statement using for statement

for (int iterator = 0; iterator < names.Length; iterator++)
{
    if (names[iterator] == "David") names[iterator] = "Sammy";
}
foreach (var name in names) Console.WriteLine(name);
