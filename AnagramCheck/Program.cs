// Read user Input
Console.Write("Enter first string: ");
string firstInput = Console.ReadLine() ?? "";
Console.Write("Enter second string: ");
string secondInput = Console.ReadLine() ?? "";

// Normalize and convert strings to char arrays
char[] firstWord = firstInput.ToLower().Trim().ToCharArray();
char[] secondWord = secondInput.ToLower().Trim().ToCharArray();

// Sort both char arrays alphabetically
Array.Sort(firstWord);
Array.Sort(secondWord);

// Convert sorted char arrays back to strings
string firstSorted = new string(firstWord);
string secondSorted = new string(secondWord);

// Compare sorted strings to determine if anagrams
if(firstSorted == secondSorted)
    Console.WriteLine($"\"{firstInput}\" and \"{secondInput}\" are anagrams!");
else
    Console.WriteLine($"\"{firstInput}\" and \"{secondInput}\" are not anagrams!");
