// ═══════════════════════════════════════
// 🧩 TASK 5: Zahlenraten mit Random 🆙
// ═══════════════════════════════════════
//
// Ein Zahlenraten-Spiel bei dem der Benutzer
// eine zufällig generierte Zahl erraten muss.
//
// Das Programm soll:
//
// 1. Eine zufällige Zahl zwischen 1 und 100 generieren
//
// 2. Den Benutzer nach einer Zahl fragen
//
// 3. Folgende Hinweise geben:
//    - Zahl ist zu klein  → "Too low! Try again."
//    - Zahl ist zu groß   → "Too high! Try again."
//    - Zahl ist korrekt   → "Correct! You guessed it!"
//
// 4. Das Spiel läuft so lange bis die Zahl erraten wurde
//
// 5. Am Ende die Anzahl der Versuche ausgeben:
//    "You guessed it in [x] attempt(s)!"
//
// Beispiel-Output:
// Guess a number between 1 and 100: 50
// Too high! Try again.
// Guess a number between 1 and 100: 25
// Too low! Try again.
// Guess a number between 1 and 100: 37
// Correct! You guessed it in 3 attempt(s)!

// Variables
bool IsInputValid = false;

// ask user for input
do
{
    Console.Write("Guess a number between 1 and 100: ");
    bool isValid = int.TryParse(Console.ReadLine(), out int userGuess);

    if(userGuess ==  false)
    {
        Console.WriteLine("Invalid Input!");
    }
    
}while(IsInputValid);


// Random Number Generator
Random rmd = new Random();
int randomNumber = rmd.Next(1, 101);