﻿/* Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);
int b = int.Parse(userInput2);
if(a > b)
{
    Console.WriteLine($"max = {a}, min = {b}");
}
else if(a < b)
{
    Console.WriteLine($"max = {b}, min = {a}");
}


