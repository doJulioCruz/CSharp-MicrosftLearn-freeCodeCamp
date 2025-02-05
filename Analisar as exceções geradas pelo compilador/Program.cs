/*

// Exceções geradas pelo compilador

// ArrayTypeMismatchException
// Uma exceção do tipo ArrayTypeMismatchException é gerada quando há uma tentativa de armazenar um elemento do tipo errado em uma matriz. O exemplo a seguir gera uma exceção ArrayTypeMismatchException quando há uma tentativa de armazenar um valor numérico em uma matriz de cadeia de caracteres.

    string[] names = { "Dog", "Cat", "Fish" };
    Object[] objs = (Object[])names;

    Object obj = (Object)13;
    objs[2] = obj; // ArrayTypeMismatchException occurs


// DivideByZeroException
// Uma exceção do tipo DivideByZeroException ocorre quando há uma tentativa de dividir um número inteiro ou decimal por zero. O exemplo a seguir gera uma exceção DivideByZeroException durante a execução de uma divisão de inteiros.

    int number1 = 3000;
    int number2 = 0;
    Console.WriteLine(number1 / number2); // DivideByZeroException occurs


// FormatException
// Uma exceção do tipo FormatException ocorre quando o formato de um argumento é inválido ou quando uma cadeia de caracteres de formato composto não está bem formada. O exemplo a seguir gera uma exceção FormatException quando há uma tentativa de converter uma cadeia de caracteres em um inteiro.

    int valueEntered;
    string userValue = "two";
    valueEntered = int.Parse(userValue); // FormatException occurs


// IndexOutOfRangeException
// A exceção do tipo IndexOutOfRangeException é gerada quando há uma tentativa de acessar um elemento de uma matriz ou de uma coleção com um índice que está fora dos limites. O exemplo a seguir gera uma exceção IndexOutOfRangeException quando há uma tentativa de atribuir o último elemento da matriz values1 ao último elemento da matriz values2.

    int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
    int[] values2 = new int[6];

    values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs


// InvalidCastException
// Uma exceção do tipo InvalidCastException é gerada quando há uma tentativa de fazer uma conversão inválida ou explícita. O exemplo a seguir gera uma InvalidCastException quando há uma tentativa de converter um object de uma cadeia de caracteres de tipo em uma variável int.

    object obj = "This is a string";
    int num = (int)obj;


// NullReferenceException
// Uma exceção do tipo NullReferenceException é gerada quando há uma tentativa de acessar um membro em um tipo cujo valor é nulo. Dois exemplos são mostrados. No primeiro exemplo, uma NullReferenceException é gerada quando há uma tentativa de acessar um elemento de uma matriz nula. O segundo exemplo gera uma NullReferenceException quando há uma tentativa de acessar um método de uma cadeia de caracteres nula.

    int[] values = null;
    for (int i = 0; i <= 9; i++)
        values[i] = i * 2;

    string? lowCaseString = null;
    Console.WriteLine(lowCaseString.ToUpper());


// OverflowException
// Uma exceção do tipo OverflowException ocorre quando uma operação aritmética tenta atribuir um resultado que está fora do intervalo do tipo de dados de destino. O exemplo a seguir gera uma exceção OverflowException quando há uma tentativa de converter um valor decimal igual a 400 em uma variável byte.

    decimal x = 400;
    byte i;

    i = (byte)x; // OverflowException occurs
    Console.WriteLine(i);


// Implementar um try-catch simples

    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }

    catch
    {
        Console.WriteLine("An exception has been caught");
    }



// Capturar exceções geradas nos métodos chamados
// Quando uma exceção é gerada e o método atual não a captura, o Common Language Runtime libera a pilha, procurando um método que contenha uma cláusula catch que possa tratar a exceção. A primeira cláusula catch encontrada que pode tratar a exceção será executada. Se nenhuma cláusula catch apropriada for encontrada em qualquer lugar na pilha de chamadas, o Common Language Runtime encerrará o processo e exibirá uma mensagem de erro para o usuário.


    try
    {
        Process1();
    }
    catch
    {
        Console.WriteLine("An exception has occurred");
    }

    Console.WriteLine("Exit program");

    static void Process1()
    {
        try
        {
            WriteMessage();
        }
        catch
        {
            Console.WriteLine("Exception caught in Process1");
        }
    }

    static void WriteMessage()
    {
        double float1 = 3000.0;
        double float2 = 0.0;
        int number1 = 3000;
        int number2 = 0;

        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }

// Capturar várias exceções em um bloco de código

    try
    {
        Process1();
    }
    catch
    {
        Console.WriteLine("An exception has occurred");
    }

    Console.WriteLine("Exit program");

    static void Process1()
    {
        try
        {
            WriteMessage();
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Exception caught in Process1: {ex.Message}");
        }
    }

    static void WriteMessage()
    {
        double float1 = 3000.0;
        double float2 = 0.0;
        int number1 = 3000;
        int number2 = 0;
        byte smallNumber;

        try
        {
            Console.WriteLine(float1 / float2);
            Console.WriteLine(number1 / number2);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Exception caught in Process1: {ex.Message}");
        }
        checked
        {
            try
            {
                smallNumber = (byte)number1;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Exception caught in Process1: {ex.Message}");
            }
        }

    }

// Capturar tipos de exceções separados em um bloco de código
// Há momentos em que as variações nos dados podem causar diferentes tipos de exceções.

    // inputValues is used to store numeric values entered by a user
    string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

    foreach (string inputValue in inputValues)
    {
        int numValue = 0;
        try
        {
            numValue = int.Parse(inputValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid readResult. Please enter a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number you entered is too large or too small.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


// Desafio de captura de exceções específicas

    
       

        try
            { 
                int num1 = int.MaxValue;
                int num2 = int.MaxValue;
                int result = checked(num1 + num2);
                Console.WriteLine("Result: " + result);
            }
        catch (OverflowException ex)
            {
                Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
            }

        try
            {
                string str = null;
                int length = str.Length;
                Console.WriteLine("String Length: " + length);
            }
        catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: The reference is null." + ex.Message);
            }

        try
        {
            int[] numbers = new int[5];
            numbers[5] = 10;
            Console.WriteLine("Number at index 5: " + numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Index out of range." + ex.Message);
        }

        try
        {
            int num3 = 10;
            int num4 = 0;
            int result2 = num3 / num4;
            Console.WriteLine("Result: " + result2);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
        }

    

    Console.WriteLine("Exiting program.");

    -SAIDAS
    Error: The number is too large to be represented as an integer. Arithmetic operation resulted in an overflow.
    Error: The reference is null. Object reference not set to an instance of an object.
    Error: Index out of range. Index was outside the bounds of the array.
    Error: Cannot divide by zero. Attempted to divide by zero.
    Exiting program.

*/