
// Задача №21.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
double z = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите четвертое число: ");
double a1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите пятое число: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите шестое число: ");
double z1 = double.Parse(Console.ReadLine()!);


double ab = Math.Sqrt(Math.Pow(a-a1, 2) + Math.Pow(b - b1, 2)+Math.Pow(z-z1, 2));

Console.Write("Расстояние между точками введенными вашими координатами ");
Console.WriteLine(ab);