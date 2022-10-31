// Choose variable names that follow the rules and conventions

// Variable names can contain alphanumeric characters and the underscore character.
// Variable names must begin with an alphabetical letter or an underscore, not a number.
// Developers use the underscore for a special purpose, so try to not use that for now.
// Developers use the underscore for a special purpose, so try to not use that for now.
// Variable name are case sensitive

using System.Net;

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


