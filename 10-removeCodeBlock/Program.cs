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