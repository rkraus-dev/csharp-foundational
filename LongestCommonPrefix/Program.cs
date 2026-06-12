string[] arr = { "dog", "racecar", "car" };
string prefix = "";

// Iterate through each character of the first word
for (int i = 0; i < arr[0].Length; i++)
{
    char current = arr[0][i];  // Current character from the first word

    // Check if all words share the same character at position i
    foreach (string word in arr)
    {
        if (i >= word.Length || word[i] != current)
        {
            // Mismatch found - print current prefix and stop
            Console.WriteLine($"Longest common prefix: \"{prefix}\"");
            return;
        }

    }

    prefix += current;
}

Console.WriteLine($"Longest common prefix: \"{prefix}\"");
