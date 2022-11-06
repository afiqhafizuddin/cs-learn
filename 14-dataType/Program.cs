// signed integral value

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int     : {int.MinValue} to {int.MinValue}");
Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}");

// unsigned integral value

Console.WriteLine("");
Console.WriteLine("Unsigned integral types");

Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue}");

//floating-point types

Console.WriteLine("");
Console.WriteLine("Floating point types");
Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue}");
Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue}");

// Reference value

int[] data = new int[5]; // declaring an array of int by using the enew keyword

// string also is a reference types. The C# designers decided that don't need to use new keyword due to the fact that string
// is used so often.

string newToProgramming = "Hello, World!";
Console.WriteLine(newToProgramming);


