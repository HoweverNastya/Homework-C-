// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 2
// По заданному номеру дня недели вывести его название.

Console.Write("введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);
int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 7;
if (day==1)
{Console.Write("Понедельник");
Console.WriteLine(a);}
if (day==2)
{Console.Write("Вторник");
Console.WriteLine(b);}
if (day==3)
{Console.Write("Среда");
Console.WriteLine(c);}
if (day==4)
{Console.Write("Четверг");
Console.WriteLine(d);}
if (day==5)
{Console.Write("Пятница");
Console.WriteLine(e);}
if (day==6)
{Console.Write("Суббота");
Console.WriteLine(f);}
if (day==7)
{Console.Write("Воскресенье");}
