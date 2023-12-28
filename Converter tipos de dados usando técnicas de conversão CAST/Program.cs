/*

//Não é possível converter implicitamente tipo "string" em "int"

    int first = 2;
    string second = "4";
    int result = first + second;
    Console.WriteLine(result);


//Compiladores fazem conversões seguras - a operação mais segura seria converter int em um string e executar a concatenação em vez disso.

    int first = 2;
    string second = "4";
    string result = first + second;
    Console.WriteLine(result);


//Tentar alterar o tipo de dados do valor resultaria em uma perda de informações? - Como qualquer valor int pode se ajustar facilmente dentro de um decimal, o compilador executa a conversão.

    int myInt = 3;
    Console.WriteLine($"int: {myInt}");

    decimal myDecimal = myInt;
    Console.WriteLine($"decimal: {myDecimal}");


//Executar uma coerção - Para executar uma coerção, use o operador de coerção () para cercar um tipo de dados e coloque-o ao lado da variável que deseja converter (por exemplo: (int)myDecimal)

    decimal myDecimal = 3.14m;
    Console.WriteLine($"decimal: {myDecimal}");

    int myInt = (int)myDecimal;
    Console.WriteLine($"int: {myInt}");


//O termo conversão de restrição significa que você está tentando converter um valor de um tipo de dados que pode conter mais informações para um tipo de dados que pode conter menos, por exemplo:


    decimal myDecimal = 1.23456789m;
    float myFloat = (float)myDecimal;

    Console.WriteLine($"Decimal: {myDecimal}");
    Console.WriteLine($"Float: {myFloat}");


//Use ToString() para converter um número em um string

    int first = 5;
    int second = 7;
    string message = first.ToString() + second.ToString();
    Console.WriteLine(message);
    Console.WriteLine(message.GetType());


//Converter um string em um int usando o método auxiliar Parse() - A maneira mais fácil é usar TryParse(), que é uma versão melhorada do método Parse().

    string first = "5";
    string second = "7";
    int sum = int.Parse(first) + int.Parse(second);
    Console.WriteLine(sum);
    Console.WriteLine(sum.GetType());


//Converter um string em um int usando a classe Convert - Você usou o método Convert.ToInt32() com uma cadeia de caracteres aqui, mas provavelmente deve usar TryParse() quando possível.

    string value1 = "5";
    string value2 = "7";
    int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
    Console.WriteLine(result);


//Comparar a coerção e a conversão de um decimal em um int - O exemplo a seguir demonstra o que acontece quando você tenta converter em cast um decimal em um int (uma conversão de restrição) em vez de usar o método Convert.ToInt32() para converter o mesmo decimal em um int

    int value = (int)1.5m;
    Console.WriteLine(value);

    int value2 = Convert.ToInt32(1.5m);
    Console.WriteLine(value2);


//Utilizar o método TryParse() para analisar uma cadeia de caracteres como um int

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measyrement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}


//O int analisado será usado posteriormente no código - Para demonstrar que a variável result declarada anteriormente contém o parâmetro out e também será usada posteriormente no código

    string value = "102";
    int result = 0;
    if (int.TryParse(value, out result))
    {
        Console.WriteLine($"Measurement: {result}");
    }
    else
    {
        Console.WriteLine("Unable to report the measurement.");
    }

    Console.WriteLine($"Measurement (w/ offset): {50 + result}");


//Modificar a variável de cadeia de caracteres para um valor que não possa ser analisado - observe o outro cenário, em que TryParse() recebe intencionalmente um valor inválido que não pode ser convertido em um int

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine($"Unable to report the Measurement.");
}

if (result > 0)
{
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
}

*/