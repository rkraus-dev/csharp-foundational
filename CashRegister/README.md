# Cash Register
A console-based cash register built in C#.

## Features
- Add items with name and price dynamically
- Loops until user stops adding items
- Prints formatted receipt with all items
- Calculates and displays total price

## Example
```
=== Cash Register ===
Enter item name: Apple
Enter item price: 1.50
Add another item? (y/n): y
Enter item name: Bread
Enter item price: 2.30
Add another item? (y/n): n

=== Receipt ===
Apple   1.50€
Bread   2.30€
─────────────────
Total   3.80€
``` 

## Chapter
04 - Strings and Methods

## Topics Practiced
- List<string> and List<double> for dynamic collections
- do while loop for user-driven input
- double.TryParse with InvariantCulture for decimal parsing
- F2 formatting for currency output
- Thread.CurrentThread.CurrentCulture for locale settings