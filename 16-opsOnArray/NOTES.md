# **Perform Operations on Arrays**

C# arrays allow to store sequences of values in a single data structure. We can manipulate the order adn contents of the array.

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
