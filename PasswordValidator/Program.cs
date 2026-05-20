// 2. Boolean Flags verwenden um diese Bedingungen zu tracken:
//    - hasMinLength:   Passwort hat mindestens 8 Zeichen
//    - hasUpperCase:   Passwort enthält mindestens einen Großbuchstaben
//    - hasLowerCase:   Passwort enthält mindestens einen Kleinbuchstaben
//    - hasDigit:       Passwort enthält mindestens eine Zahl (0-9)
//
// 3. Short-circuiting nutzen um zu prüfen ob das Passwort
//    nicht null UND nicht leer ist — bevor sonst irgendwas geprüft wird
//
// 4. Entweder ausgeben:
//    "Password is valid!"
//    oder
//    "Password is invalid!" gefolgt von einer Liste
//    was nicht erfüllt wurde
//
// Beispiel-Output (ungültig):
// Password is invalid!
// - Must be at least 8 characters
// - Must contain an uppercase letter
//
// Beispiel-Output (gültig):
// Password is valid!

// User input
Console.Write("Enter a password: ");
string password = Console.ReadLine();

// Boolean flags
bool hasMinLength = false;
bool hasUpperCase = false;
bool hasLowerCase = false;
bool hasDigit = false;

// Check password validity
if(password == null || password == "")
{ 
    Console.WriteLine("Password is invalid!");
    Console.WriteLine("- Password cannot be null or empty");
    return;
}
 // Hier Passwortprüfung

