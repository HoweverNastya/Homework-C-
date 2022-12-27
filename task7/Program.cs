// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задача 7
//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int numberA = new Random().Next(10, 99);
Console.WriteLine(numberA);

if (numberA > 10 && numberA < 99)
{
if (numberA / 10 > numberA % 10)
{
        Console.WriteLine("Первая цифра больше");
}
else
if (numberA / 10 == numberA % 10)
{
        Console.WriteLine("Цифры одинаковы");
}
else
Console.WriteLine("Вторая цифра больше");
}