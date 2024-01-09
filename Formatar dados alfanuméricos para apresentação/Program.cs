/*
// O que é a Formatação Composta? - A formatação composta usa espaços reservados numerados dentro de uma cadeia de caracteres. No runtime, tudo o que está dentro das chaves é resolvido para um valor que também é transmitido com base na posição.

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);


// Atualize seu código desta maneira:

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);


// O que é interpolação de cadeia de caracteres? - Em vez de usar um token numerado e incluir o valor literal ou nome da variável em uma lista de argumentos em String.Format() ou Console.WriteLine(), você pode apenas usar o nome da variável dentro das chaves.

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");


//Moeda de formatação - No exemplo a seguir, o especificador de formato de moeda :C é usado para apresentar as variáveis price e discount como moeda. 

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");


// Formatar números -Ao trabalhar com dados numéricos, talvez deseje formatar o número para facilitar a leitura, incluindo vírgulas para delinear milhares, milhões, bilhões e assim por diante. O especificador de formato numérico N torna os números mais legíveis.

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");


//Formatar percentuais - Use o especificador de formato P para formatar percentuais

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");


//Combinar abordagens de formatação - variáveis de cadeia de caracteres podem armazenar as cadeias de caracteres criadas usando técnicas de formatação. 

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);

Console.WriteLine(yourDiscount);


// É possível combinar diversas cadeias de caracteres formatadas. Desenvolva o código anterior concatenando a porcentagem calculada por meio da interpolação de cadeias de caracteres

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";
Console.WriteLine(yourDiscount);


// ==== PART2 ==== 
// Explorar a interpolação de cadeia de caracteres

// Exibir o número da fatura usando interpolação de cadeia de caracteres

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");

// Exibir as ações de produto com precisão de um milésimo (0,001)
Console.WriteLine($"    Shares: {productShares:N3} Product");

// Exibir o subtotal que você vai cobrar do cliente, formatado como moeda
Console.WriteLine($"    Sub Total: {subtotal:C}");

// Exibir o imposto cobrado na venda, formatado como percentual
Console.WriteLine($"        Tax: {taxPercentage:P2}");

// Finalizar o recibo com o valor total devido, formatado como moeda
Console.WriteLine($"    Total Billed: {total:C}");


// ==== PART 3 ====
// Descobrir o preenchimento e alinhamento

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);


// Formatar cadeias de caracteres adicionando um espaço em branco antes ou depois

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));


//O que é um método sobrecarregado? - um método sobrecarregado é outra versão de um método com argumentos diferentes ou extras que modificam a funcionalidade do método 

string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));


// Como trabalhar com cadeias de caracteres preenchidas

string paymentId = "769C";

var formattedLine = paymentId.PadRight(6);

Console.WriteLine(formattedLine);


// Adicionar o nome do favorecido à saída - O operador += executa uma concatenação de cadeias de caracteres, usando o valor anterior da variável formattedLine e adicionando o novo a ele.

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);

Console.WriteLine(formattedLine);


// Adicionar o valor do pagamento à saída

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadRight(10);

Console.WriteLine(formattedLine);
*/