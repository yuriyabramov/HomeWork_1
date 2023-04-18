// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 

double a = new Random().Next(1,12); 
Console.Write($"{a} ->  ");
for (int i = 1; i <= a; i++)
    if (i % 2 == 0)
        Console.Write(i);


