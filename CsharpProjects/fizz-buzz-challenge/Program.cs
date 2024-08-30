for (int i = 1; i < 101; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
        Console.WriteLine($"{i}\t-\tFizzBuzz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i}\t-\tBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i}\t-\tFizz");
    else
        Console.WriteLine(i);

}