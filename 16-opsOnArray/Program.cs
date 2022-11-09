// Sort() & Reverse()

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets); // use Sort() method of the Array class to sort the items/elements in the array alphanumerically
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");

Console.WriteLine("Reversed...");
Array.Reverse(pallets);  // use the Reverse() method of Array class to revers the items/elements in the array alphanumerically
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
// Clear() and Resize()

// Clear() method
// Empty string vs null
Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2); // clearing elements starting from 0 index for 2 elements
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}\n");

Console.WriteLine($"Clearing 2 .. count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");

// Resize() method

Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 .. count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Resizing to remove elements
Console.WriteLine("");

Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ..count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
// Split() and Join() method
string value = "abc123";
char[] valueArray = value.ToCharArray();
foreach (var val in valueArray)
{
    Console.WriteLine($"Character: {val}");
}

// reverse and then combine as a new array
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine($"\n{result}");

// Split the comma-separated string into an array of string

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine($"-- {item}");
}

Console.WriteLine("");
// Challenge 1 

// solution 1

string pangram = "The quick brown fox jumps over the lazy dog";

// variable declarations
string[] pangramStringArr = pangram.Split(" ");  // create string array that splits the words
string[] wordLength = new string[pangramStringArr.Length]; // creates new array string w/ length that of the word

for (int i = 0; i < pangramStringArr.Length; i++)
{
    char[] pangramCharArray = pangramStringArr[i].ToCharArray();
    Array.Reverse(pangramCharArray);

    wordLength[i] = new string(pangramCharArray);

}

string pangramReversed = String.Join(" ", wordLength);
Console.WriteLine(pangramReversed);

// solution 2


Console.WriteLine("");
// Challenge 2

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderArr = orderStream.Split(",");

foreach (string item in orderArr)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}