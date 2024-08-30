// Random coin = new();
// int coinFlip = coin.Next(10);
// Console.WriteLine(coinFlip < 5 ? "heads" : "tails" );

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}

else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}

else
{
    Console.WriteLine("You do not have sufficient privileges.");
}



