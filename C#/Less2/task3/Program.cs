// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = new Random().Next(1, 1001);
Console.WriteLine($"Наше первое случайное число {a}");
int b = new Random().Next(1, 101);
Console.WriteLine($"Наше второе случайное число {b}");
double x = (a % b);

if (x == 0)
    Console.Write($"второе число кратно первому = {a/b}");
else
    Console.Write($"второе число не кратно первому, остаток от деления = {a%b} ");