// Evaluate Boolean expressions to make decisions in C#
Console.WriteLine("\nStep 1");
// Step 1: using string equality  operator

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine( myValue == "a");

Console.WriteLine("\nStep 2");
// Step 2: Improve the checking by using string's built-in helper methods

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("\nStep 3");
// Step 3: Use the inequality opeator

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

Console.WriteLine(myValue != "a");

Console.WriteLine("\nStep 4");
// Step 4: Using the comaprison operator

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 >= 1);


// Methods that return Boolean value
Console.WriteLine("\nStep 5");
// Step 5: Use method invocation expression
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Console.WriteLine("\nStep 6");
// Step 6: Use logical negation operator
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

// Conditional Operator
// '?:'
// The basic form
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

Console.WriteLine("\nStep 1 Conditional Operator");
//Step 1CO
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Console.WriteLine("\nStep 2 Conditional Operator");
// Step 2
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Console.WriteLine("\nCHALLENGE 1");
// CHALLENGE 1

Random coin = new Random();
int result = coin.Next(0, 2); // either 0 and 1
Console.WriteLine($"{(result == 0 ? "heads": "tails")}");

// skipping the temp variable
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

Console.WriteLine("\nCHALLENGE 2");
// Challenge 2

// complicated permissions challenge
string permission = "Admin | Manager";
int level = 55;

// if block
if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin User");
    }
    else
    {
        Console.WriteLine("Welcome, Admin User");
    }
}
// else if block
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an admin for access");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges");
    }
}

// else block
else
{
    Console.WriteLine("You do not have sufficient privileges");
}




