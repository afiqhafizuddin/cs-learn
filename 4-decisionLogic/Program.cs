Console.WriteLine("Learning and Using if-else statements in C#"); 


Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);



int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");


if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total");
        total +=2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You Win a New Car!");
}
else if (total >= 10)
{ 
    Console.WriteLine("You Win a New Laptop!");

}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else 
{
    Console.WriteLine("You win a kitten!");
}



// Boolean Expression

string message = "The quick brown fox jumps over the lazy dog";
bool result = message.Contains("dog"); // string.Contains() method to evaluate whether one string contains another string
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

// Simple Boolean expressions can be created using operators to compare two values

// '==' : "equals" test for equality
// '>'  : "greater than" test for value on the left is greater than value on the right
// '<'  : "less than" test for value on the left is lesser than value on the right
// '>=' : "greater than or equal"
// '<=' : "lesser than or equal"

// CHALLENGE

Random challenge = new Random();
int daysUntilExpiration = challenge.Next(12); 
// int daysUntilExpiration = 4; // test code
int discountPercentage = 0;

Console.WriteLine(daysUntilExpiration); // checking

if (daysUntilExpiration <= 10)
{
    if ((daysUntilExpiration <= 5) && (daysUntilExpiration >=2)) // if 5 >= days >= 2
    {
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.\nRenew now and save 10%");
    discountPercentage = 10;
    Console.WriteLine($"You earned yourself discount value of {discountPercentage}%!");

    }
    else if (daysUntilExpiration == 1)  // if days == 1
    {
    Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%");
    discountPercentage = 20;
    Console.WriteLine($"You earned yourself discount value of {discountPercentage}%!");
    }
    else if (daysUntilExpiration == 0) // days == 0 
    {
    Console.WriteLine("Your subscription has expired");
    }
    else 
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!") ;
    }
}
else // if > 10 days
{
    // Console.WriteLine($"You still have {daysUntilExpiration} days left in your subscription!");
    Console.WriteLine();
}

 
/* ANOTHER POSSIBLE SOLUTION
 
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}


















 */







