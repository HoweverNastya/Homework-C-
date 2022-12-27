// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задача 8
//Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int b = a / 100 * 10 + a % 10;
Console.WriteLine(b);