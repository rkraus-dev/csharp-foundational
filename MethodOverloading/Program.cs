// Use invariant culture for decimal point formatting
System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

// Calls
Console.WriteLine($"Add(3, 5) = {Calculator.Add(3, 5)}");
Console.WriteLine($"Add(1.5, 2.3) = {Calculator.Add(1.5, 2.3)}");
Console.WriteLine($"Add(1, 2, 3) = {Calculator.Add(1, 2, 3)}");
Console.WriteLine("Add(\"Hello\", \" World\") = " + Calculator.Add("Hello", " World"));

// Class filled with all overloaded methods
static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static double Add(double a, double b) => a + b;
    public static int Add(int a, int b, int c) => a + b + c;
    public static string Add(string a, string b) => a + b;
}



