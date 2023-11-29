/*
// instrução FOR simples 

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


// instrução FOR de forma regressiva

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

// mudando a forma de incrementar/decrementar FOR

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

// saindo da iteração com brase em uma condição

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

// iterando por matrizes 

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}


// demonstrando que não é possivel mudar um valor na matriz durante uma iteração FOREACH

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}

// mudando valor na matriz com uma instrução FOR

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);


// conclusão do desafio

//====== SOLUÇÃO MICROSOFT ===========

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}

//======== MINHA SOLUÇÃO ==========

for ( int j = 1; j <= 100; j++)
{  
    if ((j % 3 == 0) && (j % 5 == 0))
    {
        Console.WriteLine($"{j} - FizzBuzz");
    }
    else if (j % 3 == 0)
    {
        Console.WriteLine($"{j} - Fizz");
    }else if (j % 5 == 0)
    {
        Console.WriteLine($"{j} - Buzz");
    }
    
     else {
        Console.WriteLine(j);
    }
    
        
}

*/
