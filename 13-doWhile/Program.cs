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

// Challenge

// Initialization

int heroHealth = 10;
int monsterHealth = 10;

Random attack = new Random(); 

do
{
    // hero attacks monster
    int attackVal = attack.Next(1, 11);  // all attacks valued from 1 to 10
    monsterHealth -= attackVal; // new monsterHealth 
    Console.WriteLine($"Monster was damaged and lost {attackVal} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0) continue; // continue to monster attack hero if monster still has health

    // monster attack hero
    attackVal = attack.Next(1, 11); // generate new random value
    heroHealth -= attackVal;
    Console.WriteLine($"Hero was damaged and lost {attackVal} health and now has {heroHealth} health.");

} while (heroHealth > 0 && monsterHealth > 0);

//Console.WriteLine( heroHealth > monsterHealth ? "Hero Wins!" : "Monster Wins!" );

if (monsterHealth > heroHealth)
    Console.WriteLine("Monster Wins!");
else 
    Console.WriteLine("Hero Wins!");