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

// adding new line to demonstrates that the out parameter is reusable

Console.WriteLine($"Measurement (w/ offset): 50 + {result}")
```

The int.TryParse() method will return `true` if it successfully converted our string variable value into an int; otherwise, it will return `false`. So, surround the statement in an if statement, and then perform the decision logic accordingly.

```cs
if (int.TryParse(value, out result))
```

Output of the above code block above

```
Measurement: 102
Measurement (w/ offset): 152
```

### Modifying the string variable to an unparseable value

```cs
string valUnparse = "bad";
int value3 = 0;
if (int.TryParse(valUnparse, out value3))
{
    Console.WriteLine($"Measurement: {value3}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
if (value3 > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + value3}");
```

Output of the code block above:

```
Unable to report the measurement.
```

### **Recap**

The `TryParse()` method is a valuable tool.

- Use TryParse() when converting a string into a numeric data type
- TryParse() returns `true` if the conversion is successful, `false` if it's unsuccessful.
- An out parameter provides a secondary means of a method returning a value. In this instance, out paramenter returns the converted value
- use the keyword `out` when passing in an argument to a method that has defined an out parameter

## **Challenge 1 Solution**

```cs
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// declaration of variables
decimal numericVal = 0m;
string textVal = "";

// operation code blocks
foreach (var val in values)
{
    decimal num;
    if (decimal.TryParse(val, out num))
    {
        numericVal += num;
    }
    else
    {
        textVal += val;
    }
}

Console.WriteLine($"Message: {textVal}");
Console.WriteLine($"Total: {numericVal}");
```

## **Challenge 2 Solution**

```cs
// variable declaration
int val_1 = 12;
decimal val_2 = 6.2m;
float val_3 = 4.3f;

int res_1 = val_1 / (int)val_2;
Console.WriteLine($"Divide val_1 by val_2, display the result as an int: {res_1}");

decimal res_2 = val_2 / (decimal)val_3;
Console.WriteLine($"Divide val_2 by val_3, display the result as a decimal: {res_2}");

float res_3 = val_3 / (float)val_1;
Console.WriteLine($"Divide val_3 by val_1, display the result as a float: {res_3}");

// Another solution using Convert class

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
```

## **Summary**

- **_implicit conversion_** relying on the C# compiler to perform <mark>**_widening conversions_**</mark>.
- When the C# compiler unable to perform widening conversion we use `ToString()` method to perform explicit conversions.
- <mark>**_narrowing conversions_**</mark> several different techniques are applicable.

  - use casting operator `()`, when the conversion could be made safely and we are willing to accept the truncations of values after the decimal.
  - use the `Convert()` method when wanted to perform a conversions and use common rounding rules when performing narrowing conversion.
  - Use `TryParse()` method when the conversion from `string` to numerical data type could result is data type conversion exception.
