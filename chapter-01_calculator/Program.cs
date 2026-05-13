// Step 1 - ask user for two numbers
Console.Write("Enter first number: ");
if(!decimal.TryParse(Console.ReadLine(), out decimal num1))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.Write("Enter second number: ");
if(!decimal.TryParse(Console.ReadLine(), out decimal num2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

// Step 2 - ask user for operator
// 2. Den Nutzer nach einem Operator fragen: +, -, *, /, %
Console.Write("Enter operator (+, -, *, /, %): "); 
string operat = Console.ReadLine() ?? "";


// Step 3 - check if division by zero

// Step 4 - perform calculation 

// Step 5 - output result
