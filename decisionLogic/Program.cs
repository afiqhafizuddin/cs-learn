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

// Else and else-if statements








