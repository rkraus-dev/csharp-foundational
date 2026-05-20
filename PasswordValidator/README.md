# Password Validator
A console-based password validator built in C#.

## Features
- User input with null and empty check
- Boolean flags to track password criteria
- Short-circuiting for safe input validation
- Detailed output showing which criteria were not met

## Example
```
Enter a password: hello
Password is invalid!
- Must be at least 8 characters
- Must contain an uppercase letter
- Must contain a digit

Enter a password: SecurePass1
Password is valid!
```

## Chapter
02 - Branches and Loops

## Topics Practiced
- Boolean flags
- if / else
- foreach loop
- char.IsUpper() / char.IsLower() / char.IsDigit()
- Short-circuiting with && and ||
- return for early exit
