// Switch statement best used when
// 1. have a single value you want to match against many possible values
// 2. for any given match, you have to execute a couple lines of codes

using System.Security.Principal;

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:                       // to execute 
        title = "Senior Manager";
        break;
    default:                        // when there is no match, .NET runtime will execute default value
        title = "Associate";
        break;
}
Console.WriteLine($"{employeeName}, {title}");

// CHALLENGE

// SKU: Stock Keeping Unit
string sku = "01-MN-L";
string[] product = sku.Split('-');

Console.WriteLine(product[0]);
Console.WriteLine(product[1]);
Console.WriteLine(product[2]);

string type = "";  // blank
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat Shirt";
} else if (product[0] == "02")
{
    type = "T-shirt";
} else if (product[0] == "03")
{
    type = "Sweat Pants";
} else
{
    type = "Other";
}


if (product[1] == "BL")
{
    color = "Black"; 
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");

// Using switch-case statement

// for product[0]
switch (product[0])
{
    case "01":
        type = "Sweat Shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat Pants";
        break;
    default:
        type = "Other";
        break;
}

// for product[1]
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");