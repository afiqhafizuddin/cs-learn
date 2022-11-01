//Code blocks and variable scope

// Variable scope is the visibility of the variable to the other code in your application.
// A locally scoped variable is only accessible inside of the code block in which it's defined. If you attempt
// to access the variable outside of the code block, you'll get a compiler error.

// Step 1
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}


// defining a variable outside of code blocks

bool flag1 = true;
int value2 = 0;

if (flag1)
{
    value2 = 10;
    Console.WriteLine($"Inside of code block:" + value2);
}
Console.WriteLine($"Outside of code block:" + value2);
