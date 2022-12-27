// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задача 9
// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите первое число: ");
Double FN = Double.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
Double SN = Double.Parse(Console.ReadLine()!);


   if ( FN % SN == 0 )
   {
        Console.Write("Первое число кратно второму");
   }
   else
   {
    Console.WriteLine(FN/SN);
    Console.WriteLine("Число не кратно");
   }