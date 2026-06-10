int[] numbers = { 3, 0, 1 };

// Calculate expected sum
int expectedSum  = numbers.Length * (numbers.Length + 1) / 2;

// Calculate actual array sum 
int actualSum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    actualSum += numbers[i];

}

// Calculate missing number
int missingNumber = expectedSum  - actualSum;

// Output
Console.WriteLine($"Input:  {string.Join(", ", numbers)}");
Console.WriteLine($"Missing number: {missingNumber}");