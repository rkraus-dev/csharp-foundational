Console.Write("Enter a password: ");
string userInput = (Console.ReadLine() ?? "").Trim();

// Method for checking the min length of the password
bool HasMinLength(string password)
{
    return password.Length >= 8;
}

// Method for checking if a char is Uppercase
bool HasUpperCase(string password)
{
    foreach (char c in password)
    {
        if (char.IsUpper(c))
            return true;

    }

    return false;
}

// Method for checking if a char is lowercase
bool HasLowerCase(string password)
{
    foreach (char c in password)
    {
        if (char.IsLower(c))
            return true;
    }
    return false;
}

// Method for checking if a char is a digit
bool HasDigit(string password)
{
    foreach (char c in password)
    {
        if (char.IsDigit(c))
            return true;
    }
    return false;
}

// Method for checking if a char is a special character
bool HasSpecialChar(string password)
{
    string specialChars = "!@#$%^&*";

    foreach (char c in password)
    {
        if (specialChars.Contains(c.ToString()))
            return true;
    }
    return false;

}

// Run all validation checks
bool hasMinLength = HasMinLength(userInput);
bool hasLower = HasLowerCase(userInput);
bool hasUpper = HasUpperCase(userInput);
bool hasDigit = HasDigit(userInput);
bool hasSpecial = HasSpecialChar(userInput);

if (!hasMinLength || !hasLower || !hasUpper || !hasDigit || !hasSpecial)
    Console.WriteLine("Password is invalid!");
if (!hasMinLength)
    Console.WriteLine("- Must be at least 8 characters!");
if (!hasUpper)
    Console.WriteLine("- Must contain an uppercase letter");
if (!hasLower)
    Console.WriteLine("- Must contain an lowercase letter");
if (!hasDigit)
    Console.WriteLine("- Must contain a digit");
if (!hasSpecial)
    Console.WriteLine("- Must contain a special character (!@#$%^&*)");
if(hasMinLength && hasLower && hasUpper && hasDigit && hasSpecial)
    Console.WriteLine("Password is valid!");