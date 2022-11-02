// Switch statement best used when
// 1. have a single value you want to match against many possible values
// 2. for any given match, you have to execute a couple lines of codes

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