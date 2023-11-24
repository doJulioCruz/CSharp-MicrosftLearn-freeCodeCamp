bool flag = true;
int value = 5;
if (flag) 
{
    int mais = 6;
    value = value + mais;

    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}");

/*
    Como o primeiro inteiro é inicializado acima do código da instrução if, ele continua dentro do escopo mesmo após o bloco de código. Além disso, como ambos os inteiros estão no escopo e inicializados com valores dentro do bloco de código, a adição dos valores é executada corretamente. Por fim, embora o segundo inteiro não exista fora do bloco de código, o primeiro inteiro mantém as alterações em seu valor que ocorreram dentro do bloco de código.
*/