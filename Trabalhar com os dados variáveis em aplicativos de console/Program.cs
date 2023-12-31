/*

//Criar uma matriz de paletes, depois classificá-los - Aqui, você está usando o método Sort() da classe Array para classificar os itens na matriz de modo alfanumérico.

    string[] pallets = { "B14", "A11", "B12", "A13" };

    Console.WriteLine("Sorted...");
    Array.Sort(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }


//Inverter a ordem dos paletes - inverter a ordem dos paletes usando o método Array.Reverse() 

    string[] pallets = { "B14", "A11", "B12", "A13" };

    Console.WriteLine("");
    Console.WriteLine("Reversed...");
    Array.Reverse(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }


//Chamar um método auxiliar de cadeia de caracteres em um elemento limpo - Para provar que o valor armazenado em pallets[0] após ser limpo é nulo, você modificará o exemplo de código para chamar o método ToLower() em pallets[0]. Se for uma cadeia de caracteres, ele deverá funcionar corretamente. Mas se for nulo, ele deverá fazer com que o código gere uma exceção.

    string[] pallets = { "B14", "A11", "B12", "A13" };
    Console.WriteLine("");

    Console.WriteLine($"Before: {pallets[0].ToLower()}");
    Array.Clear(pallets, 0, 2);

//Para evitar o erro, adicione a instrução if antes de acessar o elemento da matriz que pode ser nulo.

    if (pallets[0] != null)
        Console.WriteLine($"After: {pallets[0].ToLower()}");

    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }


//Redimensionar a matriz para adicionar mais elementos


    string[] pallets = { "B14", "A11", "B12", "A13" };
    Console.WriteLine("");

    Array.Clear(pallets, 0, 2);
    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 6);
    Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

    pallets[4] = "C01";
    pallets[5] = "C02";

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }


//Redimensionar a matriz para remover elementos - Por outro lado, você pode remover elementos da matriz usando Array.Resize().



    string[] pallets = { "B14", "A11", "B12", "A13" };
    Console.WriteLine("");

    Array.Clear(pallets, 0, 2);
    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 6);
    Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

    pallets[4] = "C01";
    pallets[5] = "C02";

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 3);
    Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }
    

//Use o ToCharArray() para reverter um string - Aqui você usará o método ToCharArray() para criar uma matriz de char, e cada elemento dessa matriz tem um caractere da cadeia de caracteres original.

    string value = "abc123";
    char[] valueArray = value.ToCharArray();


//Inverter e, em seguida, combinar a matriz char em uma nova cadeia de caracteres - A expressão new string(valueArray) cria uma instância vazia da classe System.String (que é a mesma do tipo de dados string em C#) e passa a matriz char como um construtor

    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Array.Reverse(valueArray);
    string result = new string(valueArray);
    Console.WriteLine(result);
    

//Combine todos os caracteres em uma nova cadeia de caracteres com valor separado por vírgula usando Join() - Para fazer isso, use o método Join() da classe String, transmitindo o caractere que você deseja delimitar em cada segmento (a vírgula) e na própria matriz.

    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Array.Reverse(valueArray);
  //string result = new string(valueArray)
    string result = String.Join(", ", valueArray);
    Console.WriteLine(result);


//Split() a nova cadeia de caracteres de valor separado por vírgula em uma matriz de cadeias de caracteres - A vírgula é fornecida para .Split() como o delimitador que divide uma cadeia de caracteres longa em cadeias menores.

    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Array.Reverse(valueArray);
    string result = String.Join(",", valueArray);
    Console.WriteLine(result);
    
    string[] items = result.Split(',');
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
*/
   //string result = new string(valueArray) linha140
