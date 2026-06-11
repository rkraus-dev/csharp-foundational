# Combat System
A console-based turn-based combat system built in C#.

## Features
- Two characters with Name, HP and Attack stats
- Turn-based combat loop until one character reaches 0 HP
- Checks after each attack to prevent dead characters from attacking
- Displays damage dealt and remaining HP each turn

## Example
``` 
Hero attacks Goblin for 15! Goblin has 85HP left.
Goblin attacks Hero for 8! Hero has 92HP left.
...
Hero attacks Goblin for 15! Goblin has 0HP left.
Hero wins!
```

## Chapter
03 - Arrays and Collections

## Topics Practiced
- do while loop for combat rounds
- break to exit loop early
- Math.Max() to clamp HP at 0
- String interpolation for combat log