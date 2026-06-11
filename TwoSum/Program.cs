// ...
int[] arr = { 2, 7, 11, 15 };
int target = 9;

// Print input
Console.WriteLine($"[{string.Join(", ", arr)}], target = {target}");

// Logic
for(int i = 0; i < arr.Length - 1; i++)
{
    for(int j = i + 1; j < arr.Length; j++)
    {
        if(target == arr[i] + arr[j])
        {
            Console.WriteLine($"Indices: [{i}, {j}] ({arr[i]} + {arr[j]} = {target})");
        }
    }

}