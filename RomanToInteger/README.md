# Roman to Integer
A console-based Roman numeral to integer converter built in C#.

## Features
- Converts any valid Roman numeral string to an integer
- Handles subtraction rule (e.g. IV = 4, XC = 90)
- Input validation with re-prompt on invalid characters

## Example
```
Enter a Roman numeral: MCMXCIV
MCMXCIV = 1994
Enter a Roman numeral: abc
Invalid input! Only Roman numerals allowed.
Enter a Roman numeral: XIV
XIV = 14
```

## Chapter
02 - Branches and Loops

## Topics Practiced
- Dictionary<string, int> for symbol mapping
- for loop with index for character iteration
- do while loop for input validation
- ContainsKey() for dictionary lookup
- Subtraction rule logic with i+1 lookahead