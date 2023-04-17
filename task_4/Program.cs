/* Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.




ЗДЕСЬ ДАЮ ДВА РЕШЕНИЯ ЗАДАЧИ: 1) ЧИСЛА ПООЧЕРЕДНО ВВОДИТ ПОЛЬЗОВАТЕЛЬ (ЗАКОММЕНТИРОВАНО); 2) ЧИСЛА ВЫВОДЯТСЯ НА ЭКРАН ПУТЕМ СЛУЧАЙНОЙ ГЕНЕРАЦИИ ЧИСЕЛ*/






/*Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write($"{a}, {b}, {c} -> {max}");*/



Random rnd = new Random();
int a = rnd.Next(); 
int b = rnd.Next(); 
int c = rnd.Next(); 
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write($"{a}, {b}, {c} -> {max}");