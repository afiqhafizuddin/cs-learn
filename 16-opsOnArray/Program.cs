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
