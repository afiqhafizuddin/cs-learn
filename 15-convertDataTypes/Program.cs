// implicit conversion - type casting

int first = 2;
string second = "4";
// int result = first + second;
string result = first + second;
Console.WriteLine(result);

// widening conversion

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt; // data type conversion happens here
Console.WriteLine($"decimal: {myDecimal}");



