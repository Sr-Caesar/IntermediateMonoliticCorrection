//1. Controllo Password piu Avanzato

static void PasswordValidationCheck(string password) 
{ 
    if (string.IsNullOrEmpty(password) || password.Length < 8)
    {
        Console.WriteLine("Password troppo corta. Deve essere di almeno 8 caratteri.");
        return;
    }

    if (!password.Any(char.IsUpper))
    {
        Console.WriteLine("La password deve contenere almeno una lettera maiuscola.");
        return;
    }

    if (!password.Any(char.IsDigit))
    {
        Console.WriteLine("La password deve contenere almeno un numero.");
        return;
    }

    // Password passes all checks
    Console.WriteLine("Password valida.");
}

//2. Statistiche Lettere
static void CharRatio()
{
    Console.Write("Inserisci una frase: ");
    string frase = Console.ReadLine();

    int lettere = 0;
    int cifre = 0;
    int spazi = 0;
    int altri = 0;

    for (int i = 0; i < frase.Length; i++)
    {
        char c = frase[i];

        if (char.IsLetter(c))
        {
            lettere++;
        }
        else if (char.IsDigit(c))
        {
            cifre++;
        }
        else if (char.IsWhiteSpace(c))
        {
            spazi++;
        }
        else
        {
            altri++;
        }
    }

    Console.WriteLine("Statistiche:");
    Console.WriteLine($"Lettere: {lettere}");
    Console.WriteLine($"Cifre: {cifre}");
    Console.WriteLine($"Spazi: {spazi}");
    Console.WriteLine($"Altri simboli: {altri}");
}
