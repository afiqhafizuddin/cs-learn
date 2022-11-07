// implicit conversion - type casting

using System.Xml.Schema;

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


// narrowing conversion

decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");

int myInt2 = (int)myDecimal2;
Console.WriteLine($"int: {myInt2}");

// use ToString() to convert string to a number

string first2 = "5";
string second2 = "7";

int sum = int.Parse(first2) + int.Parse(second2);
Console.WriteLine(sum);

// use Convert class method

string value1 = "5";
string value2 = "7";

int result2 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result2);


// Casting vs. Conversion

int val3 = (int)1.5m;
Console.WriteLine(val3);

int val4 = Convert.ToInt32(1.5m);
Console.WriteLine(val4);

Console.WriteLine("");


// TryParse() method; out parameter
string value = "102";
int result3 = 0;
if (int.TryParse(value, out result3)) // 
{
    Console.WriteLine($"Measurement: {result3}");
}
else
{
    Console.WriteLine("Unable to report the measurement");
}

Console.WriteLine($"Measurement (w/ offset): {50 + result3}");

Console.WriteLine("");
// Modify the string variable to an unparseable value

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


// Challenge
Console.WriteLine("\nChallenge 1");
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

Console.WriteLine("\nChallenge 2");
// Challenge 2

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







