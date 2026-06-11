// User Input
Console.Write("Enter a string: ");
string userInput = (Console.ReadLine() ?? "").Trim();
string cleaned = userInput.ToLower();
string reversed = ""; 

// Build reversed string
for(int i = cleaned.Length; i > 0; i--)
{
    reversed += cleaned[i -1];
}

// Check if string is a palindrome
if(cleaned == reversed)
    Console.WriteLine($"\"{userInput}\" is a palindrome!");
else
    Console.WriteLine($"\"{userInput}\" is not a palindrome!");
