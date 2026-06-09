// Variables
bool IsInputValid = false;
int userGuess = 0;
int attemptCounter = 0;

// ask user for input
do
{
    Console.Write("Guess a number between 1 and 100: ");
    IsInputValid = int.TryParse(Console.ReadLine(), out userGuess);

    if (!IsInputValid)
    {
        Console.WriteLine("Invalid Input!");
    }

} while (!IsInputValid);

// Random Number Generator
Random rmd = new Random();
int randomNumber = rmd.Next(1, 101);

// Game loop - repeat until correct number is guessed
while (userGuess != randomNumber)
{
    // Counts the Attempts
    attemptCounter++;

    // Check if Input from User is Higher or Lower from the Goal
    if (userGuess > randomNumber)
        Console.WriteLine("Too High! Try again!");
    else if (userGuess < randomNumber)
        Console.WriteLine("Too Low! Try again");

    // Re-prompt user until valid number is entered
    do
    {
        Console.Write("Guess a number between 1 and 100: ");
        IsInputValid = int.TryParse(Console.ReadLine(), out userGuess);

        if (!IsInputValid)
        {
            Console.WriteLine("Invalid Input!");
        }

    } while (!IsInputValid);

}
    attemptCounter++;
    Console.WriteLine($" Correct! You guessed it in {attemptCounter} attempt(s)!");