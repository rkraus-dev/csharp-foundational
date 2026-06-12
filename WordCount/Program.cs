// Read user input
Console.Write("Enter a text: ");
string userInput = Console.ReadLine() ?? "";

// Split input into words and initialize dictionary
string[] words = userInput.Trim().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

Dictionary<string,int> dict = new Dictionary<string, int>();

// Count occurrences of each word
foreach(string s in words)
{
    if(dict.ContainsKey(s))
        dict[s]++;
    else    
        dict[s] = 1;
}

// Print word counts
foreach(KeyValuePair<string,int> s in dict)
{
    Console.WriteLine($"{s.Key}: {s.Value}");
}