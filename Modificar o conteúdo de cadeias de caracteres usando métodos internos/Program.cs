/*
// Escreva um código para encontrar pares de parênteses inseridas em uma cadeia de caracteres
    string message = "Find what is (inside the parentheses)";

// Adicione o código para recuperar o valor entre parênteses    
    int openingPosition = message.IndexOf('(');
    int closingPosition = message.IndexOf(')');

    Console.WriteLine(openingPosition);
    Console.WriteLine(closingPosition);

// Ao aumentar openingPosition em 1, o caractere de parêntese de abertura é ignorado
    openingPosition += 1;

// O método Substring() precisa da posição inicial e do número de caracteres, ou comprimento, para recuperar
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));



// Evitar valores mágicos - Evite valores mágicos codificados. Em vez disso, defina uma variável const. O valor de uma variável constante não pode ser alterado após a inicialização.

    string message = "What is the value <span>between the tags</span>";

    const string openSpan = "<span>";
    const string closeSpan = "</span>";

    int openingPosition = message.IndexOf(openSpan);
    int closingPosition = message.IndexOf(closeSpan);

    openingPosition += openSpan.Length;
    int length = closingPosition - openingPosition;
    
    Console.WriteLine(message.Substring(openingPosition, length));


// Recuperar a última ocorrência de uma subcadeia de caracteres - Neste exemplo, o uso de LastIndexOf() é essencial, pois ele é empregado para obter as posições dos últimos parênteses de abertura e fechamento.

    string message = "(What if) I am (only interested) in the last (set of parentheses)?";
    int openingPosition = message.LastIndexOf('(');

    openingPosition += 1;
    int closingPosition = message.LastIndexOf(')');
    int length = closingPosition - openingPosition;

    Console.WriteLine(message.Substring(openingPosition, length));


// Recuperar todas as instâncias de subcadeias de caracteres dentro de parênteses -Desta vez, você atualiza o message para ter três conjuntos de parênteses e escreve o código para extrair qualquer texto dentro deles.

    string message = "(What if) I am (only interested) in the last (set of parentheses)?";

    while(true)
    {
        int openingPosition = message.IndexOf('(');
        if (openingPosition == -1) break;

        openingPosition += 1;
        int closingPosition = message.IndexOf(')');
        int length = closingPosition - openingPosition;

        Console.WriteLine(message.Substring(openingPosition, length));

        message = message.Substring(closingPosition + 1);
    }


// Trabalhar com diferentes tipos de conjuntos de símbolos - Desta vez, você pesquisar vários símbolos diferentes, não apenas um conjunto de parênteses.

    string message = "Help (find) the {opening symbols}";
    Console.WriteLine($"Searching THIS Message: {message}");

    Console.WriteLine();

    char[] openSymbols = { '[', '{', '('};
    int startPosition = 6;
    int openingPosition = message.IndexOfAny(openSymbols);
    Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

    Console.WriteLine();

    openingPosition = message.IndexOfAny(openSymbols, startPosition);
    Console.WriteLine($"Found WITH using startPosition: {startPosition}: {message.Substring(openingPosition)}");
    

// Agora que você encontrou um símbolo de abertura, precisa encontrar o símbolo de fechamento correspondente.

    string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

    char[] openSymbols = { '[', '(', '{'};

    int closingPosition = 0;

    while(true)
    {
        int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

        if (openingPosition == -1)break;

        string currentSymbol = message.Substring(openingPosition, 1);

        char matchingSymbol = ' ';

        switch(currentSymbol)
        {
            case "[":
                matchingSymbol = ']';
                break;
            case "{":
                matchingSymbol = '}';
                break;
            case "(":
                matchingSymbol = ')';
                break;
        }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
    }


// Remover caracteres em locais específicos de uma cadeia de caracteres - O método Remove() funciona de forma semelhante ao método Substring(). Defina uma posição inicial e o comprimento para remover esses caracteres da cadeia de caracteres.

    string data = "12345John Smith          5000  3  ";
    string updatedData = data.Remove(5, 20);
    Console.WriteLine(updatedData);


// Remover caracteres, independentemente de onde eles aparecem em uma cadeia de caracteres

    string message = "This--is--ex-amp-le--da-ta";

    message = message.Replace("--"," ");
    message = message.Replace("-", "");

    Console.WriteLine(message);
*/