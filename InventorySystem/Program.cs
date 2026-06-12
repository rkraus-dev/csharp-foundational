// Use invariant culture for decimal point formatting
System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

// Initialize inventory lists
List<string> names = new List<string>();
List<int> quantities = new List<int>();
List<double> prices = new List<double>();

string userInput = "";

do
{
    // Print menu
    Console.WriteLine("=== Inventory System ===");
    Console.WriteLine("[1] Add Item");
    Console.WriteLine("[2] Remove Item");
    Console.WriteLine("[3] Show Inventory");
    Console.WriteLine("[0] Exit");
    Console.Write("Choose an option: ");

    // Read user input
    userInput = Console.ReadLine() ?? "";

    switch (userInput)
    {
        case "1":
            AddItem(names, quantities, prices);
            break;
        case "2":
            RemoveItem(names, quantities, prices); 
            break;
        case "3":
            ShowInventory(names, quantities, prices);
            break;
        case "0":
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid Option!");
            break;
    }

    Console.WriteLine();

} while (userInput != "0");


// Inventory management methods
// Method for adding items
void AddItem(List<string> names, List<int> quantities, List<double> prices)
{
    Console.Write("Enter item name: ");
    string item = Console.ReadLine() ?? "";
    names.Add(item);

    Console.Write("Enter quantity: ");
    int.TryParse(Console.ReadLine(), out int quantity);
    quantities.Add(quantity);

    Console.Write("Enter price: ");
    double.TryParse(Console.ReadLine(), out double price);
    prices.Add(price);

    Console.WriteLine("Item added!");
}

//Method for removing items
void RemoveItem(List<string> names, List<int> quantities, List<double> prices)
{
    Console.Write("Enter item name to remove: ");
    string userInput = Console.ReadLine() ?? "";
    int index = names.IndexOf(userInput);

    if (index != -1)
    {
        names.RemoveAt(index);
        quantities.RemoveAt(index);
        prices.RemoveAt(index);
        Console.WriteLine($"Item \"{userInput}\" removed!");
    }
    else
        Console.WriteLine($"Item \"{userInput}\" not found!");

}

// Method for print all items with total price
void ShowInventory(List<string> names, List<int> quantities, List<double> prices)
{
    double total = 0;
    Console.WriteLine("\t=== Inventory ===");
    Console.WriteLine("Name\tQty\tPrice\tTotal");
    for(int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{names[i]}\t{quantities[i]}\t{prices[i]:F2}€\t{quantities[i] * prices[i]:F2}€");
        total += prices[i] * quantities[i];
    }
    
    Console.WriteLine("─────────────────────────────────");
    Console.WriteLine($"Total Value: {total:F2}€");
}