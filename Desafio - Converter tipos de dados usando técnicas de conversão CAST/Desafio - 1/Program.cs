using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US"); //para modificar o separador decimal de "," para "." 

/*
Regra 1: Se o valor for alfabético, concatene-o para formar uma mensagem.
Regra 2: se o valor for numérico, adicione-o ao total.
Regra 3: o resultado deve corresponder à seguinte saída:

SAIDA:
Message: ABCDEF
Total: 68.3

*/

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal result = 0;
decimal numeros = 0;

string letras = "";

foreach (string elementos in values)
{

    if (decimal.TryParse(elementos, out result))
    {
        numeros = numeros + result;
    }
    else
    {
        letras = letras + elementos;
    }
}

Console.WriteLine($"Message: {letras}");
Console.WriteLine($"Total: {numeros}");
