int input = -1;

// Display menu and handle user input
do
{
    Console.WriteLine("=== Main Menu ===");
    Console.WriteLine("[1] Say Hello");
    Console.WriteLine("[2] Add Two Numbers");
    Console.WriteLine("[3] Check Even or Odd");
    Console.WriteLine("[0] Exit");
    Console.Write("Choose an option: ");

    bool isValid = int.TryParse(Console.ReadLine(), out input);

    if (!isValid)
    {
        Console.WriteLine("Invalid input! Please enter a number.");
        input = -1;
    }
    else
    {
        switch (input)
        {
            case 1:
                SayHello();
                break;
            case 2:
                AddTwoNumbers();
                break;
            case 3:
                CheckEvenOrOdd();
                break;
            case 0:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid Option!");
                break;
        }
    }

} while (input != 0);


// Method for "Hello World!" output
void SayHello()
{
    Console.WriteLine("Hello World!");
}

// Method for adding two numbers
void AddTwoNumbers()
{
    Console.Write("Please input first Number: ");
    int.TryParse(Console.ReadLine(), out int num1);
    Console.Write("Please input second Number: ");
    int.TryParse(Console.ReadLine(), out int num2);

    Console.WriteLine($"Result: {num1 + num2}");
}


// Method to check if input is Even or Odd 
void CheckEvenOrOdd()
{
    Console.Write("Please input a number: ");
    int.TryParse(Console.ReadLine(), out int num);

    if (num % 2 == 0)
        Console.WriteLine($"The number is even!");
    else
        Console.WriteLine("The number is odd!");

}
