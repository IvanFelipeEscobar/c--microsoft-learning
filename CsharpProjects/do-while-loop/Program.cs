﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

Console.WriteLine("\n");

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine("\n");

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
