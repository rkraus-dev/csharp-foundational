Console.Write("Enter a password: ");
string userInput = Console.ReadLine() ?? "";

// Method for checking the min length of the password
bool hasMinLength(string password)
{
    return password.Length >= 8;
}

// Method for checking if a char is Uppercase
bool hasUpperCase(string password)
{
    foreach (char c in password)
    {
        if (char.IsUpper(c))
            return true;

    }

    return false;
}

// Method for checking if a char is lowercase
bool hasLowerCase(string password)
{
    foreach (char c in password)
    {
        if (char.IsLower(c))
            return true;
    }
    return false;
}

// Method for checking if a char is a digit
bool hasDigit(string password)
{
    foreach (char c in password)
    {
        if (char.IsDigit(c))
            return true;
    }
    return false;
}

// Method for checking if char is a special char
bool hasSpecialChar(string password)
{
    string specialChars = "!@#$%^&*";

    foreach(char c in password)
    {
        if(specialChars.Contains(c.ToString()))
            return true;
    }
    return false;

}