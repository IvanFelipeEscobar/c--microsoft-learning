
Console.Clear();

Console.Write("\"a\" == \"a\"\t");
Console.WriteLine("a" == "a");

Console.Write("\"a\" == \"A\"\t");
Console.WriteLine("a" == "A");

Console.Write("1 == 2\t");
Console.WriteLine(1 == 2);
Console.WriteLine("----------------------------------------------------------- ");
string myValue = "a";
Console.WriteLine(myValue == "a");
Console.WriteLine("----------------------------------------------------------- ");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
Console.WriteLine("----------------------------------------------------------- ");

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);
string myValue1 = "a";
Console.WriteLine(myValue1 != "a");
Console.WriteLine("----------------------------------------------------------- ");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

Console.WriteLine("----------------------------------------------------------- ");

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Console.WriteLine("----------------------------------------------------------- ");

string pangram1 = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram1.Contains("fox"));
Console.WriteLine(!pangram1.Contains("cow"));

Console.WriteLine("----------------------------------------------------------- ");
int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");