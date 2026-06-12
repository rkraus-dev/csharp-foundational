# Character Compression
A console-based string compression exercise built in C#.

## Features
- Compresses consecutive repeated characters with their count
- Returns original string if compressed version is longer
- Uses index-based comparison for adjacent characters

## Example
``` 
Enter a string: aabcccdddd
Compressed: a2b1c3d4

Enter a string: abc
Compressed: abc (original is shorter)
``` 

## Chapter
04 - Strings and Methods

## Topics Practiced
- for loop with i and i+1 comparison
- Counter reset on character change
- ^1 index syntax for last element
- String concatenation with +=
- Length comparison for fallback to original