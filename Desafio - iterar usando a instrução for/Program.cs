/*
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