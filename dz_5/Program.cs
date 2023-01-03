// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задача 5
//Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int b = a % 10;
Console.WriteLine(b);
