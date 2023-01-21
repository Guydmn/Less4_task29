// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите 3х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000)
{
    Console.Write($"Ваше новое число {a / 100}");
    Console.Write(a % 10);
}
else
{
    Console.Write("Вы ввели неверное число");
}