/*

// Projeto de código 1 – escrever o código que valida a entrada de inteiro

string? readResult;
bool validEntry = false;
Console.WriteLine("Insira um número entre 5 e 10: ");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (int.TryParse(readResult, out int numero))
        {
           if ((numero < 5) || (numero > 10))
            {
                Console.WriteLine($"{readResult} não é um número válido, insira um número entre 5 e 10");
            }else
            {
                Console.WriteLine($"Ok, ({readResult}) foi aceito.");
                validEntry = true;
            } 
        }
        else
        {
           Console.WriteLine($"{readResult} não é um número, tente novamente: ");
        }
    }
} while (validEntry == false);


// Projeto de código 2 – escrever o código que valida a entrada de cadeia de caracteres

string? readInput;
bool validEntry = false;
Console.WriteLine("Insira sua função: (\"Administrador\", \"Gerente\" ou \"Usuário\".) ");

while (validEntry == false)
{
    readInput = Console.ReadLine();
    string cargos = readInput!.Trim().ToLower();

    switch(cargos)
    {
        case "administrador":
        case "gerente":
        case "usuario":
            validEntry = true;
            Console.WriteLine($"Seu valor de entrada ({readInput}) foi aceito.");
            break;
        default:
            Console.WriteLine($"Sua entrada ({readInput}) não foi aceita, insira novamente.");
            cargos = readInput!.Trim().ToLower();
            break;
    }
}


// Projeto de código 3: escreva um código que processe o conteúdo de uma matriz de caracteres

string[] myStrings = new string[2] { "Gosto de pizza. Gosto de frango assado. Gosto de salada", "Gosto das três opções do menu" };

foreach (string stringOriginal in myStrings)
{
    string reatribuindoString = stringOriginal;
    int periodLocation = reatribuindoString.IndexOf('.');

    while(periodLocation != -1)
    {
        string frase = reatribuindoString.Substring(0, periodLocation).TrimStart();
        Console.WriteLine(frase);

        reatribuindoString = reatribuindoString.Remove(0, periodLocation + 1);
        periodLocation = reatribuindoString.IndexOf('.');
    }

    Console.WriteLine(reatribuindoString.Trim());
}    

*/