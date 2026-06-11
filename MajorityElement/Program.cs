// Input array
int[] arr = { 3, 2, 3 };

// Count occurrences of each element
Dictionary<int, int> dict = new Dictionary<int, int>();

//Print array
Console.WriteLine($"[{string.Join(", ", arr)}]");

// Populate dictionary with element counts
foreach (int i in arr)
{
    if (dict.ContainsKey(i))
        dict[i]++;
    else
        dict[i] = 1;
}

// Find element that appears more than n/2 times
foreach (KeyValuePair<int, int> item in dict)
{
    if(item.Value > arr.Length / 2)
    {
        Console.WriteLine($"Majority Element: {item.Key}");
    }
}
