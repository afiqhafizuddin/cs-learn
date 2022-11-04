Random random = new Random();   
// int current = 0;
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    if (current >= 8) continue; // if current >= 8; skips the next line and redo the loop
    Console.WriteLine(current);
} while (current != 7); // stops the iteration if current = 7



/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last Number: {current}");
*/

