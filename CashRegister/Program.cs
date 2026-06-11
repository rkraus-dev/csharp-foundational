// Use invariant culture for decimal point formatting
System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

// Initialize lists and variables
List<string> item = new List<string>();
List<double> prices = new List<double>();
string userInput = "";
double total = 0;

// Print Cash Register
Console.WriteLine("=== Cash Register ===");

// Loop to collect items and prices from user
do
{
    Console.Write("Enter item name: ");
    userInput = (Console.ReadLine() ?? "").Trim();
    item.Add(userInput);

    Console.Write("Enter item price: ");
    double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double priceUserInput);
    prices.Add(priceUserInput);

    Console.Write("Add another item? (y/n): ");
    userInput = Console.ReadLine() ?? "";
    
}while(userInput == "y"); 

// Print receipt header
Console.WriteLine();
Console.WriteLine("=== Receipt ===");

// Print each item with price
for(int i = 0; i < item.Count; i++)
{
    Console.WriteLine($"{item[i]}\t{prices[i]:F2}€");
    total += prices[i];
}

// Print Total
Console.WriteLine("─────────────────");
Console.WriteLine($"Total\t{total:F2}€");