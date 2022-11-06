# **Data Type Casting & Conversion**

1. Q1: Is it possible, depending on the value, that attempting to change the value's data type, the compiler would throw an exception at runtime?
2. Q2: Is it possible, depending on the value, that attemption to change the value's data type would result in the loss of information?

## **Q1: The explanation for the first question**

C# compiler will always try to accommodate the code that is written, but will always avoid the code that could result in an exception.

```cs
int first = 2;
string second = "4";
// int result = first + second;
string result = first + second;
Console.WriteLine(result);
```

In the C# code block above, the C# compiler sees a potential issues when converting `string` data type to `int`. Hence, when `result` is passed as `int` data type the compiler returns error.

However, the C# compiler has no problem at implicitly converting `int` to `string` data type, and hence, when `result` is passed as `string`, the code executes.

### Summary

- `int` to `string` : C# compiler can execute implicit conversion
- `string` to `int` : C# compiler cannot execute the conversion implicitly.

notes:

- If there is a nedd for a conversion of string, you have to take more control and involved more, by performing explicit data conversion.
- Data conversion must be performed if the data conversion would throw an exception at runtime.

### Data Conversion Techniques

1. Using Helper method on the daa type
2. Using Helper method on the variable
3. Using Convert Class.

## **Q2: The explanation of the second question**

### **Widening Convesion**

- _widening conversion_ - converting a value from a less holding information data type to a more holding information data type. In this case, you'll lose no information. Example, when converting data type from `int` to `decimal`.

```cs
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt; // data type conversion
Console.WriteLine($"decimal: {myDecimal}");
```

Since any int value can easily fit inside of a decimal, the compiler performs the conversion.

### **Narrowing conversion**

- _narrowing conversion_ - means attempting to <mark>perform data type conversion from a more holding information data type to a less holding information data type.</mark> There will be a lose information in terms of precision. AN example would be, converting a value from `decimal` data type to `int` data type.
- When performing narrowing conversion - cast must be done. Casting is an instruction to the C# compiler that tells the compiler we are willing to perform a data coversion that may results in loss of information.

```cs
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal; // type casting
Console.WriteLine($"int: {myInt}");
```

```
decimal: 3.14
int: 3
```

```cs
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");
```

```
Decimal: 1.23456789
Float: 1.234568
```

## **Performing Data Conversion**

1. Use ToString() to convert number to a string

```cs
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
```

```
12
```

The potential problems in the above example is what if both `first` and `second` cannot be converted to `int`? An exception will be thrown at runtime. A beter solution would be to use TryParse() method.

2. Data Conversion using Convert class

The Convert class has many helper methods to convert a value from one type into another.

```cs
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
```

The `ToInt32()` named as is instead of `ToInt()` due to the fact that `System.Int32` is the underlying data type name in the .NET Class Library that map to `int` data type in C#. Since Convert is a class in the.NET CLass Library, it is called by its full name and not its C# name.

By defining the same data types in the .NET Class Library, multiple .NET languages like F#, VB.NET and IronPython can have the share the same data types and classes.

The `Convert` class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect.

## Conversion vs. Casting

The following demonstrates when casting a `decimal` to `int` versus using the `Convert.ToInt32()` to convert the same `decimal` to `int`.

```cs
int value = (int)1.5m;
Console.WriteLine("value");

int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2);
```

```
1
2
```

## **The TryParse() method**

- it attempts to a string into given a numeric data type
- if successful, it will store the converted value in an out parameter
- it returns a bool whether the operation is successful or not

### **What is an out parameter**

- Methods can return value or return "void", means return no value.
- Methods also returns an out parameter, which are defined just like in parameter, but with `out` keyword
- When calling a method with an `out` parameter, must also use the `out` keyword before the variable.

```cs
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
```

```cs
Console.WriteLine($"Measurement: {result}");
```
