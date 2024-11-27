Random random = new Random();

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
        var target = RollDice();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int RollDice()
{
    return random.Next(1, 7);
}

bool ShouldPlay()
{
    string input = Console.ReadLine();
    return input.ToLower() == "y";
}

string WinOrLose(int t, int r)
{
    if (t >= r)
    {
        return "Loose";
    }
    else
    {
        return "Win";
    }
}