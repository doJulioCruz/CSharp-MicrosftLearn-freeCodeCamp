/*
int[] numbers = {4, 8, 15, 16, 23, 42};

int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

// Verificar seus conhecimentos

//Um desenvolvedor escreve um código que inclui um bloco de código da instrução if. Eles inicializam uma primeira variável inteira para um valor de 1 acima (fora) do bloco de código. A expressão booleana para o bloco de código de declaração if é avaliada como true se a primeira variável inteira tiver um valor maior que 0. A primeira linha de código dentro do bloco de código é usada para inicializar uma segunda variável de inteiro para um valor de 8. A segunda linha de código dentro do bloco de código é usada para atribuir a soma dos dois valores inteiros à primeira variável. A primeira linha de código após o bloco de código é usada para exibir o valor do primeiro número inteiro. Qual é o resultado quando o código é executado?

int pri = 1;
if(pri > 0){
    int seg = 8;
    pri = pri + seg;
}
Console.WriteLine(pri);

//Correto! Como o primeiro inteiro é inicializado acima do código da instrução if, ele continua dentro do escopo mesmo após o bloco de código. Além disso, como ambos os inteiros estão no escopo e inicializados com valores dentro do bloco de código, a adição dos valores é executada corretamente. Por fim, embora o segundo inteiro não exista fora do bloco de código, o primeiro inteiro mantém as alterações em seu valor que ocorreram dentro do bloco de código.



Um desenvolvedor escreve um código que inclui um bloco de código da instrução if. Eles inicializam uma primeira variável inteira para um valor de 5 acima (fora) do bloco de código. A expressão booleana para o bloco de código de declaração if é avaliada como true se a primeira variável inteira tiver um valor maior que 0. A primeira linha de código dentro do bloco de código é usada para inicializar uma segunda variável de inteiro para um valor de 6. A primeira linha de código após o bloco de código é usada para adicionar o segundo valor inteiro ao valor do primeiro inteiro. A segunda linha de código após o bloco de código é usada para exibir o valor do primeiro inteiro. Qual é o resultado quando o código é executado? 

int pri = 5;
if(pri > 0){
    int seg = 6;
}    pri = pri + seg;
Console.WriteLine(pri);

Um erro de build é gerado pelo código que soma os dois inteiros. O erro informa que a segunda variável não existe no contexto atual. A segunda variável não está no escopo fora do bloco de código.

*/