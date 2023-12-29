using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US"); //para modificar o separador decimal de "," para "." 

/*
Resolva o desafio de modo que a sua saída seja semelhante a:

Divide value1 by value2, display the result as an int: 2

Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605

Divide value3 by value1, display the result as a float: 0.3583333

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / (int)value2;
decimal result2 = value2 / (decimal)value3;
float result3 = value3 / (float)value1;

Console.WriteLine($"Dividir value1 por value2, exibir o resultado como int: {result1}");
Console.WriteLine($"Dividir value2 por value3, exibir o resultado como decimal: {result2}");
Console.WriteLine( $"Dividir value3 por value1, exibir o resultado como float: {result3}");