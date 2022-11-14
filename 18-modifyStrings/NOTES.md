<h1 align="center"><strong>Modify the content of strings built-in string data type methods in C#</strong></h1>

## <strong>Use `IndexOf()` & `Substring()`</strong>

- `IndexOf()` & its variants

  - `IndexOfAny()`
  - `LastIndexOf()`
  - to locate the position of one character or string inside a larger string
  - use `Substring()` method to return the rest of the string after the position
  - use an overloaded version of the `Substring()` method to set the number of cars (lenght) to return after the position

    ```cs
    // IndexOf() and Substring() helper methods

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
    ```

  - avoid using magic values like hardcoded strings like `"<span>"` and hardcoded numeric values like `6`.
  - These magic values are undesireable as it increases the possibility of writing code errors
  - use constant with `const` keyword. A constant allows you to define and initialize a variable whose value can never be changed.
  - Use the constant in the rest of the code whenever you needed that value. Ensures that the value is only defined once, and mispelling it will be caught by the compiler

    ```cs
    //  a better way & a safer way of writing the code

    string newerMessage = "What is the value <div>between the tags</div>?";


    const string openDiv = "<div>";
    const string closeDiv = "</div>";

    int openingDiv = newerMessage.IndexOf(openDiv);
    int closingDiv = newerMessage.IndexOf(closeDiv);

    openingDiv += openDiv.Length;

    int newerLength = closingDiv - openingDiv;
    Console.WriteLine(newerMessage.Substring(openingDiv, newerLength));
    ```

- `LastIndexOf()` usage to retrieve the last occureance of a substring

  - increase the complexity of the strings modified by adding more pair of parentheses
  - and write code to retrieve the last pair of parentheses
  - use to get the positions of the last opening and closing parentheses

    ```cs
    // use LastIndexOf() to retrieve he last occurence of a sub string

    string harderMessage = "(What if) I am (only interested) in the last (set of parentheses)?";

    int lastOpenParentheses = harderMessage.LastIndexOf('(');
    lastOpenParentheses += 1;

    int lastCloseParentheses = harderMessage.LastIndexOf(')');
    int newStringLength = lastCloseParentheses - lastOpenParentheses;

    Console.WriteLine(harderMessage.Substring(lastOpenParentheses, newStringLength));
    ```

- Applying both `IndexOf()` and `LastIndexOf()` for a harder exercise

  - retrieve any value between one or more sets of parentheses in a string

    ```cs
    // to return the text between every set of parentheses

    string harderMessage = "(What if) I am (only interested) in the last (set of parentheses)?";

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
    ```

- Work with multiple sets of characters in a string and return the string in between

  ```cs
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
  ```

## <strong>Recap</strong>

1. `IndexOf()` gives the first position of a character or a string in a string.
2. `IndexOf()` returns `-1` if it can't find a match
3. `Substring()` returns specified portion of a string using a starting position and optional length
4. `LastIndexOfAny()` returns the last position of a string or char inside of another string
5. `IndexOfAny()` returns the first position of an array of `char`.
6. There's often more than one way to solve a problem. We used two separate techniques to find all instances of a given character or string.
7. Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't be changed after initialization.
