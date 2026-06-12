# Inventory System
A console-based inventory management system built in C#.

## Features
- Add items with name, quantity and price
- Remove items by name
- Display inventory with total value per item and overall total
- Menu-driven interface with input validation

## Example
``` 
=== Inventory System ===
[1] Add Item
[2] Remove Item
[3] Show Inventory
[0] Exit
Choose an option: 3

        === Inventory ===
Name    Qty     Price   Total
Apple   10      1.50€   15.00€
Bread   5       2.30€   11.50€
Milk    3       0.99€   2.97€
─────────────────────────────────
Total Value: 29.47€
````

## Chapter
04 - Strings and Methods

## Topics Practiced
- List<string>, List<int>, List<double> for dynamic storage
- void methods with List parameters
- IndexOf() and RemoveAt() for item removal
- do while loop for menu navigation
- switch statement for option handling
- F2 formatting for currency output
- InvariantCulture for decimal point formatting