// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задача 6
//Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int b = a / 10 % 10;
Console.Write("Вторая цифра трехзначного числа");
Console.WriteLine(b);