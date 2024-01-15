// extrair, substituir e remover dados de uma cadeia de caracteres de entrada

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;

quantity = input.Substring(openingPosition, length);

Console.WriteLine($"Quantity: {quantity}");

const string initialPosition = "<div>";
const string finalPosition = "</div>";

int começa = input.LastIndexOf(initialPosition);
int termina = input.LastIndexOf(finalPosition);

começa += initialPosition.Length;
int comprimento = termina - começa;
output = input.Substring(começa, comprimento).Replace("&trade", "&reg");


Console.WriteLine($"Output: {output}");

/*
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/