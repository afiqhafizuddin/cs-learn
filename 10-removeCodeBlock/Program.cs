bool flag = true;
if (flag)
    Console.WriteLine(flag);

// else if and if statemnets without code blocks
string name = "Robert";

if (name == "Bob")
    Console.WriteLine("Found Bob");
else if (name == "Robert")
    Console.WriteLine("Found Robert");
else
    Console.WriteLine("Found Chuck");

// Recap & Summary
// If you realize you only have one line of code in a code block, you can remove the curly braces and white space.
// Only remove code blocks when it makes the code more readable.
// Only remove the line feed if it makes the code more readable

// Challenge

int[] numbers = { 4, 8, 15, 16, 23, 42 };
// define variable
int total = 0;
bool found = false;

// main code blocks
foreach (int number in numbers)
{
    total += number;
    if (number == 42) found = true;
}

if (found)
{
    Console.WriteLine("Set contains 42");
    Console.WriteLine($"Total: {total}");
}

// moved the total and found variables outside the foreach statement
// initializing both total and found with sensible default values
