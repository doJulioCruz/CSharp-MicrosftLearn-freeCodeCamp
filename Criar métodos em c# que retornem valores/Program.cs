/*
// Entender a sintaxe do tipo de retorno - Os métodos podem retornar qualquer tipo de dados ou não podem retornar nada. O tipo de retorno sempre deve ser especificado antes do nome do método.

    double total = 0;
    double minimumSpend = 30.00;

    double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
    double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

    for (int i = 0; i < items.Length; i++)
    {
        total += GetDiscountedPrice(i);
    }

    total -= TotalMeetsMinimum() ? 5.00 : 0.00;

    Console.WriteLine($"Total: ${FormatDecimal(total)}");

    double GetDiscountedPrice(int itemIndex)
    {
        return items[itemIndex] * (1 - discounts[itemIndex]);
    }

    bool TotalMeetsMinimum()
    {
        return total >= minimumSpend;
    }

    string FormatDecimal(double input)
    {
        return input.ToString().Substring(0, 5);
    }


// Retornar números de métodos - É preciso retornar os números dos métodos e utilizar os resultados para outras tarefas. Neste breve exercício, você praticará o retorno de tipos de dados int e double e a captura dos valores de retorno.

    double usd = 23.73;
    int vnd = UsToVnd(usd);

    Console.WriteLine($"${usd} USD = ${vnd} VND");
    Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

    int UsToVnd(double usd)
    {
        int rate = 23500;
        return (int) (rate * usd);
    }

    double VndToUsd(int vnd)
    {
        double rate = 23500;
        return vnd / rate;
    }


// Retornar cadeias de caracteres de métodos - O entrevistador solicita que você escreva um método para inverter uma cadeia de caracteres sem usar string.Reverse.
    string input = "there are snakes at the zoo";

    Console.WriteLine(input);
    Console.WriteLine(ReverseSentence(input));
    
    string ReverseSentence(string input)
    {
        string result = "";
        string[] words = input.Split(" ");

        foreach(string word in words)
        {
            result += ReverseWord(word) + " ";
        }

        return result.Trim();
    }

    string ReverseWord(string word)
    {
        string result = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            result += word[i];
        }

        return result;
    }


// Retornar boolianos de métodos - Métodos que retornam valores bool podem ser chamados para avaliar a entrada de dados em qualquer lugar, em instruções if, em declarações de variáveis e muito mais. 

    string[] words = { "racecar", "talented", "deified", "tent", "tenet"};

    Console.WriteLine("Is is a palindrome?");
    foreach(string word in words)
    {
        Console.WriteLine($"{word}: {IsPalindrome(word)}");
    }

    bool IsPalindrome(string word)
    {
        int start = 0;
        int end = word.Length -1;

        while (start < end)
        {
            if (word[start] != word[end])
            {
                return false;
            }
            start++;
            end--;

        }
        return true;
    }


// Restornar matrizes de métodos - Suponha que você tenha várias moedas de valores diferentes. Você tem a tarefa de encontrar duas moedas cuja soma seja igual a um valor de destino. Neste exercício, as moedas disponíveis são representadas em uma matriz de inteiros. Você precisará retornar os índices das duas moedas em uma nova matriz.

    int target = 30;
    int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
    int[,] result = TwoCoins(coins, target);

    if (result.Length == 0)
    {
        Console.WriteLine("No two coins make charge");
    }
    else
    {
        Console.WriteLine($"Charge found at positions");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            if (result[i,0] == -1)
            {
                break;
            }
            Console.WriteLine($"{result[i,0]}, {result[i,1]}");
        }
    }

    int[,] TwoCoins(int[] coins, int target)
    {
        int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1},};
        int count = 0;

        for (int curr = 0; curr < coins.Length; curr++)
        {
            for (int next = curr + 1; next < coins.Length; next++)
            {
                if (coins[curr] + coins[next] == target)
                {
                    result[count, 0] = curr;
                    result[count, 1] = next;
                    count++;
                }
                if (count == result.GetLength(0))
                {
                    return result;
                }
            }
        }
        return (count == 0) ? new int[0,0] : result;
    }
*/