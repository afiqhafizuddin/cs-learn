# **Perform Operations on Arrays**

C# arrays allow to store sequences of values in a single data structure. We can manipulate the order and contents of the array.

- **Learning Objective**
  - Sort & reverse the order of array elements
  - clear and resize the elements of an array
  - split a string into an array of strings or characters
  - join array elements into a string

## **Sort() and Reverse()**

- `Sort()` method
  - using `Sort()` method of Array class and accept array as an argument.
  - `Sort()` method sort the elements in an array aphanumerically

```cs
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets); // use Sort() method of the Array class to sort the items/elements in the array alphanumerically
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
```

- Output

```
Sorted...
-- A11
-- A13
-- B12
-- B14
```

- `Reverse()` method
  - `Reverse()` method flip the elements in an array alphanumerically

```cs
Console.WriteLine("Reversed...");
Array.Reverse(pallets);  // use the Reverse() method of Array class to revers the items/elements in the array alphanumerically
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
```

- Output

```
Reversed...
-- B14
-- B12
-- A13
-- A11
```

## **`Clear()` and `Reverse()` method**

The `Array.Clear()` method allows us to remove the contents of specific elements in our array, and the `Array.Resize()` method adds or removes elements from our array

- `Clear()` method

```cs
// Clear() and Resize()

// Clear() method
// Empty string vs null
Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2); // clearing elements starting from 0 index and clearing for 2 elements
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}\n");

Console.WriteLine($"Clearing 2 .. count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
```

- Empty string vs null

When you `Array.Clear()`, the elements that were cleared no longer reference a string in memory. In fact, the element points to nothing at all. This is an important distinction that can be difficult to grasp at first

- `Resize()` method

```cs
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
```

## **`Split()`** and **`Join()`**

- string data type's Array methods

```cs
string value = "abc123";
char[] valueArray = value.ToCharArray();

```
