// Input array
int[] numbers = { 0, 1, 0, 3, 12 };

Console.WriteLine($"Input:  {string.Join(", ", numbers)}");

int insertPos = 0;

// Move non-zero values to the front
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] != 0)
    {
        numbers[insertPos] = numbers[i];
        insertPos++;
    }
}

// Fill remaining positions with zeroes
for (int i = insertPos; i < numbers.Length; i++)
{
    numbers[i] = 0;
}



Console.WriteLine($"Output: {string.Join(", ", numbers)}");