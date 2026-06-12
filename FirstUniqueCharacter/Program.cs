// Track if a unique character was found
bool found = false;

// Read user input
Console.Write("Enter a string: ");
string userInput = Console.ReadLine() ?? "";

 // Count character occurrences
Dictionary<char, int> dic = new Dictionary<char, int>();

// Populate dictionary with character counts
foreach (char c in userInput)
{
    if (dic.ContainsKey(c))
        dic[c]++;
    else
        dic[c] = 1;
}

// Find first character with count of 1
for (int i = 0; i < userInput.Length; i++)
{
    if (dic[userInput[i]] == 1)
    {
        Console.WriteLine($"First unique character: {userInput[i]}");
        found = true;
        break;
    }
}

if (!found)
        Console.WriteLine("No unique character found!");
    