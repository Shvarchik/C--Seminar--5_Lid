﻿// Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Вводите чиcла или CTRL+Z to exit:");
string line;
int count = 0;

while ((line = Console.ReadLine()) != null)
{
    int i = int.Parse(line);
    if (i > 0) count++;
}
Console.WriteLine($"{count} чисел больше 0");

// do
// {
//     line = Console.ReadLine();
//     if (line != null)
//     {
//         int i = int.Parse(line);
//         if (i > 0) count++;
//     }
// } while (line != null);
//
// Console.WriteLine($"{count} чисел больше 0");