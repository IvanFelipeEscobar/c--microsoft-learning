// for (int i = 0; i < 10; i +=2)
// {
//     Console.WriteLine(i);
// }
// for (int i = 10; i >= 0; i--)    
// {
//     Console.WriteLine(i);
// }
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("\nchange here\t\thit enter to continue\n");
Console.Read();

string[] otherNames = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < otherNames.Length; i++)
    if (otherNames[i] == "David") otherNames[i] = "Sammy";

foreach (var name in otherNames) Console.WriteLine(name);

Console.WriteLine("\n\nhit enter to continue");
Console.Read();