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

//3. ATM

static void RunAtm()
{
    double balance = 1000.0;
    bool running = true;

    while (running)
    {
        PrintMenu();
        Console.Write("Scelta: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Withdraw(ref balance);
        }
        else if (choice == 2)
        {
            Deposit(ref balance);
        }
        else if (choice == 3)
        {
            ShowBalance(balance);
        }
        else if (choice == 4)
        {
            running = false;
            Exit();
        }
        else
        {
            Console.WriteLine("Scelta non valida.");
        }
    }
}

static void PrintMenu()
{
    Console.WriteLine();
    Console.WriteLine("=== BANCOMAT ===");
    Console.WriteLine("1. Prelievo");
    Console.WriteLine("2. Deposito");
    Console.WriteLine("3. Visualizza saldo");
    Console.WriteLine("4. Esci");
}

static void Withdraw(ref double balance)
{
    Console.Write("Importo da prelevare: ");
    double amount = double.Parse(Console.ReadLine());

    if (amount > 0 && amount <= balance)
    {
        balance -= amount;
        Console.WriteLine("Prelievo effettuato.");
    }
    else
    {
        Console.WriteLine("Prelievo non valido.");
    }
}

static void Deposit(ref double balance)
{
    Console.Write("Importo da depositare: ");
    double amount = double.Parse(Console.ReadLine());

    if (amount > 0)
    {
        balance += amount;
        Console.WriteLine("Deposito effettuato.");
    }
    else
    {
        Console.WriteLine("Deposito non valido.");
    }
}

static void ShowBalance(double balance)
{
    Console.WriteLine($"Saldo attuale: {balance} €");
}

static void Exit()
{
    Console.WriteLine("Uscita dal bancomat.");
}


//static void Main()  per testare
//{
//    RunAtm();
//}


// 4. D&D hit canche
static bool IsHit(int roll, int attackBonus, int armorClass)
{
    // 1 naturale: fallimento automatico
    if (roll == 1)
        return false;

    // 20 naturale: successo automatico
    if (roll == 20)
        return true;

    return roll + attackBonus >= armorClass;
}


static double HitChance(int attackBonus, int armorClass)
{
    int successCount = 0;

    for (int roll = 1; roll <= 20; roll++)
    {
        if (IsHit(roll, attackBonus, armorClass))
        {
            successCount++;
        }
    }

    return (successCount / 20.0) * 100.0;
}
