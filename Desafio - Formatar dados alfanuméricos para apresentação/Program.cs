string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

string firstLine = string.Format("Dear {0},\nAs a customer of our {1} offering we are excited to tell you about a new financial product that would dramatically increase your return.", customerName, currentProduct);

string secondLine = string.Format($"\nCurrently, you own {currentShares:C} shares at a return of {currentReturn:P2}.");

string thirdLine = string.Format($"\nOur new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine(firstLine);
Console.WriteLine(secondLine);
Console.WriteLine(thirdLine);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += ($"{currentReturn:P2}").PadRight(10);
comparisonMessage += ($"{currentProfit:C}");

comparisonMessage += "\n";
comparisonMessage += ($"{newProduct}").PadRight(20);
comparisonMessage += ($"{newReturn:P2}").PadRight(10);
comparisonMessage += ($"{newProfit:C}");

// Your logic here

Console.WriteLine(comparisonMessage);