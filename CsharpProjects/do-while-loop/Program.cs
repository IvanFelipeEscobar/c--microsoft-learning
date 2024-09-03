// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// Console.WriteLine("\n");

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }

// Console.WriteLine("\n");

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);


// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);
string? readResult;
bool validEntry = false;
// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);

    if (validNumber)
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine($"Your input ( {numericValue} ) is invalid, please try again.\n Enter an integer value between 5 and 10: ");
        }
    }
    else
    {

        Console.WriteLine("Sorry, you entered an invalid number, please try again.\nEnter an integer value between 5 and 10:");
    }
} while (validEntry == false);

Console.Write($"Your input value ( {numericValue} ) has been accepted.\n\n\npress enter to continue...\n\n");
Console.Read();


string? roleResult;
bool validRole = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
do
{
    roleResult = Console.ReadLine();
    string trimmedResult = roleResult?.Trim().ToLower();
    if (roleResult != null)
    {
        switch (trimmedResult)
        {
            case "administrator":
                Console.WriteLine("Your input value (Administrator) has been accepted.");
                validRole = true;
                break;
            case "manager":
                Console.WriteLine("Your input value (Manager) has been accepted.");
                validRole = true;
                break;
            case "user":
                Console.WriteLine("Your input value (User) has been accepted.");
                validRole = true;
                break;
            default:
                Console.WriteLine($"\nThe role name that you entered, \"{roleResult}\" is not valid. \nEnter your role name (Administrator, Manager, or User):\n");
                continue;
        }
    }
} while (validRole == false);

Console.WriteLine("\n\nPress enter to conitune ...\n\n");
Console.Read();

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
foreach (string myString in myStrings)
{
    if (myString.IndexOf(".") == -1)
        Console.WriteLine(myString);
    else
    {
        string[] sentences = myString.Split('.');
        foreach (string sentence in sentences)
        {
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}