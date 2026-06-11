// User Input 
Console.Write("Enter a String: ");
string userInput = (Console.ReadLine() ?? "").Trim();

Console.Write("Reversed: ");

// Loop to reverse the user input
for (int i = userInput.Length; i > 0; i--)
{
    Console.Write(userInput[i -1]);
}
