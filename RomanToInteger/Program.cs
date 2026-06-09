string userInput = "";

// Map roman symbols to their integer values
Dictionary<string, int> romanValues = new Dictionary<string, int>()
{
    {"I",1},
    {"V",5},
    {"X",10},
    {"L",50},
    {"C",100},
    {"D",500},
    {"M",1000}
};

// Check if input is valid
bool isValid = false;
do
{
    isValid = true; // assume valid, prove otherwise
    
    Console.Write("Enter a Roman numeral: ");
    userInput = Console.ReadLine();
    
    // check every character
    foreach (char c in userInput)
    {
        if (!romanValues.ContainsKey(c.ToString()))
        {
            isValid = false;
            Console.WriteLine("Invalid input! Only Roman numerals allowed.");
            break;
        }
    }

} while (!isValid);

int result = 0; // accumulates the total integer value

for (int i = 0; i < userInput.Length; i++)
{
    string currentSymbol = userInput[i].ToString();
    int currentValue = romanValues[currentSymbol];

    if (i < userInput.Length - 1)
    {
        int nextValue = romanValues[userInput[i + 1].ToString()];

        if (currentValue < nextValue)
        {
            // subtract: smaller symbol before larger means subtraction (e.g. IV = 4)
            result -= currentValue;
        }

        else
        {
            // add current symbol value to result
            result += currentValue;
        }
    }
    else
    {
        // last symbol always adds to result
        result += currentValue;
    }
}

Console.WriteLine($"{userInput} = {result}");
