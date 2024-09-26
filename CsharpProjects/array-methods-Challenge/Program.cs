string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArray = pangram.Split(' ');

string[] reversedArray = new string[pangramArray.Length];

for (int i = 0; i < pangramArray.Length; i++)
{
    char[] words = pangramArray[i].ToCharArray();
    Array.Reverse(words);
    reversedArray[i] = new string(words);

}

string reversedSentence = string.Join(" ", reversedArray);
Console.WriteLine("---------------------------------Challenge----------------------------");

Console.WriteLine(reversedSentence);

Console.WriteLine("---------------------------------Excercise----------------------------");

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);

foreach (string order in orders)
{
    if (order.Length != 4)
        Console.WriteLine($"{order}\t - Error");
    else
        Console.WriteLine(order);
}

