//Integrals
Console.Clear();
Console.WriteLine("\n--------------------------------------------\n");

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("\n--------------------------------------------\n");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("\n--------------------------------------------\n");
//Floating-point Types

Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

Console.WriteLine("\n--------------------------------------------\n");

//String

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

Console.WriteLine("\n--------------------------------------------\n");
//Practical concerns using value and reference types

int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

Console.WriteLine("\n--------------------------------------------\n");

int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");

Console.WriteLine("\n--------------------------------------------\n\nType Casting");
Console.WriteLine("\n--------------------------------------------\n");

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
Console.WriteLine("\n--------------------------------------------\n");

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
Console.WriteLine("\n--------------------------------------------\n");

decimal myDecimaly = 3.14m;
Console.WriteLine($"decimal: {myDecimaly}");

int myInty = (int)myDecimaly;
Console.WriteLine($"int: {myInty}");

Console.WriteLine("\n--------------------------------------------\n");


decimal mDecimal = 1.23456789m;
float mFloat = (float)mDecimal;

Console.WriteLine($"Decimal: {mDecimal}");
Console.WriteLine($"Float  : {mFloat}");
Console.WriteLine("\n--------------------------------------------\n");

int firstNum = 5;
int secondNum = 7;
string mess = firstNum.ToString() + secondNum.ToString();
Console.WriteLine(mess);

string fir = "5";
string sec = "7";
int sum = int.Parse(fir) + int.Parse(sec);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int res = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(res);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value9 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value9);