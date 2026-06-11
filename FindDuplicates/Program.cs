// Array
int[] numbers = { 1, 2, 3, 2, 4, 3, 5 };

// Track seen numbers and duplicates
HashSet<int> seen = new HashSet<int>();
HashSet<int> duplicates = new HashSet<int>();

 // Iterate through array and detect duplicates
foreach(int num in numbers)
{
    if(!seen.Add(num))
        duplicates.Add(num);
}
// Print results
Console.WriteLine($"Input: [{string.Join(", ", numbers)}]");
Console.WriteLine($"Duplicates: {string.Join(", ", duplicates)}");

