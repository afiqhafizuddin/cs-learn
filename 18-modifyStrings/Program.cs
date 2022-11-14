// IndexOf() and Substring() helper methods

using System.Security.AccessControl;

string message = "Find what is (inside the parentheses)";
string newMessage = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

int newOpeningPosition = newMessage.IndexOf("<span>");
int newClosingPosition = newMessage.IndexOf("</span>");

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

openingPosition += 1;
newOpeningPosition += 6;


int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

int newLength = newClosingPosition - newOpeningPosition;
Console.WriteLine(newMessage.Substring(newOpeningPosition, newLength));

//  a better way & a safer way of writing the code

string newerMessage = "What is the value <div>between the tags</div>?";


const string openDiv = "<div>"; // 
const string closeDiv = "</div>";

int openingDiv = newerMessage.IndexOf(openDiv);
int closingDiv = newerMessage.IndexOf(closeDiv);

openingDiv += openDiv.Length;

int newerLength = closingDiv - openingDiv;
Console.WriteLine(newerMessage.Substring(openingDiv, newerLength));

// use LastIndexOf() to retrieve he last occurence of a sub string

string harderMessage = "(What if) I am (only interested) in the last (set of parentheses)?";

int lastOpenParentheses = harderMessage.LastIndexOf('(');
lastOpenParentheses += 1;

int lastCloseParentheses = harderMessage.LastIndexOf(')');
int newStringLength = lastCloseParentheses - lastOpenParentheses;

Console.WriteLine(harderMessage.Substring(lastOpenParentheses, newStringLength));

// to return the text between every set of parentheses
while (true)
{
    int openPos = harderMessage.IndexOf('(');
    if (openPos == -1) break; // if the IndexOf() can't find 

    openPos += 1;
    int closePos = harderMessage.IndexOf(')');
    int newLen = closePos - openPos;

    Console.WriteLine(harderMessage.Substring(openPos, newLen));

    // overloaded Substring() to return the unprocessed string
    harderMessage = harderMessage.Substring(closePos + 1);
}


// more advanced example

string advancedText = "(What if) i have [different symbols] but every {open symbol} needs a [matching closing symbols]?";

// the IndexOf() requires an char array 
// what we want to look for

char[] openSymbols = {'{', '[', '('};

// use the closing position of the previous iteration as the starting index for the next openign symbol. 
// we'll declare closing position as zero

int closePosition = 0;

while (true)
{
    int openPosition = advancedText.IndexOfAny(openSymbols, closePosition);
    if (openPosition == -1) break;  

    string currentSymbol = advancedText.Substring(openPosition, 1);

    // to find matching symbol

    char matchingSymbol = ' '; //  initialize empty strings 

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // to find the closePosition, use an overloaded version of IndexOf() to specify
    // that our search of matching symbols should start at the index of openPosition in the string

    openPosition += 1;
    closePosition = advancedText.IndexOf(matchingSymbol, openPosition);

    // use the substring technique to display the intended substring

    int len = closePosition - openPosition;
    Console.WriteLine(advancedText.Substring(openPosition, len));

}

// Use Remove()  and Replace() methods

// Remove()
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20); // starting position and length
Console.WriteLine(updatedData);

// Replace()
string newString = "This---is---exam--ple---da--ta";
newString = newString.Replace("---", " ");
newString = newString.Replace("--", "");

Console.WriteLine(newString + "\n");


// Challenge

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string newOpenSpan = "<span>";      
const string newCloseSpan = "</span>";

int firstSpan= input.IndexOf(newOpenSpan);
int secondSpan = input.IndexOf(newCloseSpan);

firstSpan += newOpenSpan.Length;

newLength = secondSpan - firstSpan; 
quantity = input.Substring(firstSpan, newLength);

const string newOpenDiv = "<div>";
const string newCloseDiv = "</div>";

int  firstDiv = input.IndexOf(newOpenDiv);
int secondDiv = input.IndexOf(newCloseDiv);

newLength = secondDiv - firstDiv;  // int can be updated
output = input.Substring(firstDiv, newLength).Replace("&trade", "&reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");