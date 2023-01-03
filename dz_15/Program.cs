// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число номер дня недели ");
int day = int.Parse(Console.ReadLine()!);

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(day == a)
{
    Console.WriteLine ("Понедельник");
    Console.WriteLine ("Будний день");
}

if(day == b)
{
    Console.WriteLine ("Вторник");
    Console.WriteLine ("Будний день");
}
if(day == c)
{
    Console.WriteLine ("Среда");
    Console.WriteLine ("Будний день");
}
if(day == d)
{
    Console.WriteLine ("Четверг");
    Console.WriteLine ("Будний день");
}
if(day == e)
{
    Console.WriteLine ("Пятница");
    Console.WriteLine ("Будний день");
}
if(day == f)
{
    Console.WriteLine ("Суббота");
    Console.WriteLine ("Урааа! Сегодня выходной!");
}
if(day == g)
{
    Console.WriteLine ("Воскресение");
    Console.WriteLine ("Урааа! Сегодня выходной!");
}