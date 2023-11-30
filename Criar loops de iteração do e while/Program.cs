/*
// escrever uma intrução do-while que seja interrompida quando determinado número aleatório for gerado

Random random = new Random();
int current = 0;

do 
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);



// Escrever uma instrução while que itere somente enquanto um número aleatório for maior que determinado valor


Random random = new Random();
int current = random.Next(1, 11);


while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");


// Usar a instrução continue para passar diretamente para a expressão booliana

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    Console.WriteLine("xx");
    if (current >= 8) continue;

    Console.WriteLine(current);    
} while (current != 7);
*/

