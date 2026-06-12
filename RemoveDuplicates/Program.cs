// Input array
int[] numbers = { 1, 2, 3, 2, 4, 3, 5 };
// Track seen numbers and build result without duplicates
HashSet<int> seen = new HashSet<int>();
List<int> result = new List<int>();

// Iterate and add only unique numbers to result
foreach(int num in numbers)
{
    if (seen.Add(num))
    {
        result.Add(num);
    }
}


// Print input and deduplicated output 
Console.WriteLine($"Input: [{string.Join(", ", numbers)}]");
Console.WriteLine($"Output: [{string.Join(", ", result)}]");