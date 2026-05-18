// Variable Declaration
bool isPrime = true;

// User Input
Console.Write("Enter a number to check if it's a prime number: ");
bool isValid = int.TryParse(Console.ReadLine(), out int number);

if (!isValid)
{
    Console.WriteLine("Invalid input! Please enter a whole number.");
    return;
}

// Check if number is smaller than 2
if(number < 2)
{
    Console.WriteLine($"{number} is not a prime number");
    isPrime = false;
    return;
}

// Check for factors from 2 to number - 1
for(int i = 2; i <= number - 1; i++) 
{
    if(number % i == 0)
    {
        isPrime = false;
        break;
    }

}

// Output
if(isPrime)
    Console.WriteLine($"{number} is a prime number!");
else
    Console.WriteLine($"{number} is not a prime number!");
