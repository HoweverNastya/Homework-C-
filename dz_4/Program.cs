// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задача 4
//Выяснить является ли число чётным

Console.Write("введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a%2==0)
{Console.Write("четное число");
}
else
{
    Console.WriteLine("нечетное число");
}