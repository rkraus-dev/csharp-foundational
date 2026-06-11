//...
Console.Write("How many Fibonacci numbers?: ");
int.TryParse(Console.ReadLine(), out int input);

int num1 = 0;
int num2 = 1;

Console.WriteLine();
Console.Write("Fibonacci: ");

for (int i = 0; i < input; i++)
{
    if (i < input - 1)
        Console.Write($"{num1}, ");
    else
        Console.Write($"{num1}");

    int fibo = num1 + num2;
    num1 = num2;
    num2 = fibo;

}