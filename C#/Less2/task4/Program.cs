// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = new Random().Next(1, 1001);
Console.WriteLine($"Наше случайное число {a}");
int x1 = a % 7;
int x2 = a % 23;

if (x1 == 0 && x2 == 0)
    Console.Write("Число одновременно кратно и 7 и 23");
else
    Console.Write("Число одновременно не кратно 7 и 23");