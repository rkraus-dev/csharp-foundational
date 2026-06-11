// Input array
int[] arr = { 5, 3, 8, 1, 2 };

// Print input 
Console.WriteLine($"Input: [{string.Join(", ", arr)}]");

// Bubble Sort Logic 
for (int i = 0; i < arr.Length; i++)
{
    // Compare adjacent elements and swap if out of order
    for (int j = 0; j < arr.Length - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;

        }

    }
}

// Print Output
Console.WriteLine($"Output: [{string.Join(", ", arr)}]");

