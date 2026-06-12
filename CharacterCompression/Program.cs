// Initialize counter and result string
int counter = 1;
string result = "";

// Read user input
Console.Write("Enter a string: ");
string userInput = Console.ReadLine() ?? "";

// Compress string by counting consecutive characters
for (int i = 0; i < userInput.Length - 1; i++)
{
    if (userInput[i] == userInput[i + 1])
    {
        counter++;
    }
    else
    {
        result += userInput[i] + counter.ToString();
        counter = 1;
    }
}

// Append last character with its count
result += userInput[^1] + counter.ToString();

// Return original if compressed version is longer
if(result.Length > userInput.Length)
    Console.WriteLine($"Compressed: {userInput} (original is shorter)");
else
    Console.WriteLine($"Compressed: {result}");
