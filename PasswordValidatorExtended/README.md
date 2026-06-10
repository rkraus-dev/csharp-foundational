# Password Validator Extended
A console-based password validator built in C#.

## Features
- Validates password against 5 rules
- Shows which rules are not fulfilled
- Trims whitespace from input
- Clear valid / invalid output message

## Example
```
Enter a password: hello
Password is invalid!

Must be at least 8 characters
Must contain an uppercase letter
Must contain a digit
Must contain a special character (!@#$%^&*)


Enter a password: Hello123!
Password is valid!
```

## Chapter
02 - Branches and Loops

## Topics Practiced
- Local methods with bool return type
- PascalCase method naming convention
- foreach loop for character iteration
- char.IsUpper / IsLower / IsDigit for char checks
- string.Contains for special character check
- Trim() for whitespace removal
- Null-coalescing operator ??