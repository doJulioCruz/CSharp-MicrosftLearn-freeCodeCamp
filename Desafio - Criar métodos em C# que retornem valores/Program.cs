Random random = new Random();
var target = random.Next(1, 7);
var roll = random.Next(1, 7);
Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;
    while (play) 
    {        
        target = random.Next(1,7);
        roll = random.Next(1,7);
        
        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose()); // vai comparar o target com o roll
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    var readEntry = Console.ReadLine()!.ToLower();
    
        if(readEntry == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }     

string WinOrLose()
{
    if(roll <= target)
    {
      //  Console.WriteLine("You lost!");
        return "You lost!";
    }
    else
    {
     //   Console.WriteLine("You win!");
        return "You win!";
    }
}