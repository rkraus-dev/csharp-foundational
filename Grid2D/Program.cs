// Grid & Variables
int sum = 0;
int max = 0;
int[,] grid =
{
    {13,2,3},
    {4,5,6},
    {7,8,9}

};

// Output of Grid, Sum and Max
Console.WriteLine("Grid:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        // write current cell value
        Console.Write($"{grid[i, j]} ");
        // add all numbers from the grid
        sum += grid[i,j];
        // check which number is max 
        if(max < grid[i,j])
            max = grid[i,j];
    }
    Console.WriteLine();
}

// Console Output
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Max: {max}");