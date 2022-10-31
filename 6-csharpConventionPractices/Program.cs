// Choose variable names that follow the rules and conventions

// Variable names can contain alphanumeric characters and the underscore character.
// Variable names must begin with an alphabetical letter or an underscore, not a number.
// Developers use the underscore for a special purpose, so try to not use that for now.
// Developers use the underscore for a special purpose, so try to not use that for now.
// Variable name are case sensitive

using System.Net;
using System.Net.Http.Headers;

string firstName = "Bob";
int widgetsPurchased = 7;
// Console.WriteLine($"{ firstName} sold { widgetsPurchased} widgets ");
Console.WriteLine($"{ firstName} purchased { widgetsPurchased} widgets ");

Random random = new Random();
string[] orderIDs = new string[5];

for (int i=0; i<orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 75); // Generates character accroding ASCII (A - K)
    string prefix = Convert.ToChar(prefixValue).ToString(); // convert to char and then to string
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// Using whitespaces

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!");
    }
    else
    {
        Console.WriteLine("You rolled doubles!");
    }
}

// Challenge

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string str = "The quick brown fox jumps over the lazy dog";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage); 
int x = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    }
}
string newMessage = new String(charMessage);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {x} times");
// Console.WriteLine(charMessage);



