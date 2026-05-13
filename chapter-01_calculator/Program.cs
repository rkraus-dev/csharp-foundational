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
Console.Write("Enter operator (+, -, *, /, %): "); 
string operat = Console.ReadLine() ?? "";

// Step 3 - perform calculation (check if division by zero)
decimal result = 0m;
if(operat == "+")
{
    //add
    result = num1 + num2;
}
else if(operat == "-")
{
    //subtract
    result = num1 - num2;
}
else if(operat == "*")
{
    // multiply
    result = num1 * num2;
}
else if(operat == "/")
{
    //divide
    // check for division by zero
    if(num2 == 0)
    {
        Console.WriteLine("Cannot divide by zero!");
        return;
    }

    result = num1 / num2;
}
else if(operat == "%")
{
    //modulo
    result = num1 % num2;
}
else
{
    Console.WriteLine("Invalid Operator!");
}

// Step 4 - output result
