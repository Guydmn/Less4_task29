// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное число {a}");

if (a > 99 && a < 1000)
{
    Console.Write($"Ваше новое число {a / 100}");
    Console.Write(a % 10);
}
else
{
    Console.Write("Вы ввели неверное число");
}