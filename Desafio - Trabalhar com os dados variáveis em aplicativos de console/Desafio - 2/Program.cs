string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// Divide a string usando a vírgula como delimitador
string[] orderArray = orderStream.Split(',');

// Ordena a matriz alfabeticamente
Array.Sort(orderArray);

// Exibe a matriz resultante com status de erro para strings fora da faixa desejada
foreach(var item in orderArray)
{
    if(item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}