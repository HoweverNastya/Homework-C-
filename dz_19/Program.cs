
// Задача №19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом. 

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;
int b = number.Length;

if (b == 5 )

if ( number[0] == number[4] && number[1] == number[3])
Console.WriteLine($"{number} - Палиндром!");

else
Console.Write("Это не палиндром.");

else 
Console.Write("Введено не пятизначное число! Попробуй еще раз ");
