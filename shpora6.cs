// Циклы:
// Прерывание - break

// Console.WriteLine("Начало цикла");
// for (int i = 0; i < 10; i++)
// {
//     if (i == 2)
//     {
//         Console.WriteLine($"{i} это уже и так много");
//         break; // прерывание цикла и выход из него
//     }
//     Console.WriteLine(i);
// }
// Console.WriteLine("Конец цикла");

// Переход к следущей итерации - continue
// Console.WriteLine("Начало цикла");
// for (int i = 0; i < 4; i++)
// {
//     if (i == 2)
//     {
//         Console.WriteLine($"Мне не нравится квадрат {i}");
//         continue;
//     }
//     Console.WriteLine(i * i);
// }
// Console.WriteLine("Конец цикла");

// Двумерные массивы:
// определение
// int[,] arr = new int[2,3] // [количество строк, количество столбцов]
// {
//     {1, 2, 3}, // [2,3] - [количество одномерных массивов, длина каждого одномерного массива]
//     {2, 3, 4}
// };
// // или
// int[,] arr = 
// {
//     {1, 2, 3},
//     {2, 3, 4}
// };
// // или
// int[,] arr = new int[2,3];

// Получение длин массива:
// количество элементов (всего)
// int[,] arr = new int[2,3] // [количество строк, количество столбцов]
// {
//     {1, 2, 3},
//     {2, 3, 4}
// };
// int arrayLength = arr.Length;
// Console.Write(arrayLength); // 6

// // количество строк
// int linesCount = arr.GetLength(0);
// Console.Write(linesCount); // 2

// // количество столбцов
// int columnsCount = arr.GetLength(1);
// Console.Write(columnsCount); // 3

// Заполнение двумерного массива:
// int[,] arr = new int[2, 3];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(0, 10);
//     }
// }

// // Вывод двумерного массива
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine(arr[0, 0]);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = new double[5];
// for (int i = 0; i < array.Length; i++)
// {
//     double number = new Random().Next(0, 10) + new Random().NextDouble(); // 8 + 0.22 = 8.22
//     array[i] = Math.Round(number, 2); // округление числа: Math.Round(число для округления, количество знаков)
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// // При таком варианте мы никогда не ошибёмся с диапазоном массива, потому что первое число массива
// // есть в массиве, а остальные либо меньше, либо больше, либо равны ему
// double min = array[0];
// double max = array[0];

// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// bool IsNumberInArray(int number, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] array = new int[8];
// array = FillArray(array);
// PrintArray(array);
// Console.WriteLine("\n Введите \n число: ");
// int number = int.Parse(Console.ReadLine());
// // bool isNumberInArray = IsNumberInArray(number, array);
// bool isInArray = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == number)
//     {
//         isInArray = true;
//         break;
//     }
// }
// // // Все операции сравнения и равенства - bool
// // // 5 > 8 -- тоже bool
// if (isInArray)
// {
//     Console.WriteLine($"Число {number} есть в массиве");
// }
// else
// {
//     Console.WriteLine($"Числа {number} нет в массиве");
// }



//+от Юлии
// Пример настоящей программы
using System;

namespace GB.Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 5;
            int square = number * number;
            Console.WriteLine(square);
        }
    }
}


// Конец примера настоящей программы


// // DRY - don't repeat yourself - не повторяйся 
// (повторяющиеся код или действия выносить в методы или циклы)

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }

// // Делаем какие-то операции

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }
// // Вывод по DRY: если у нас два раза нужно вывести массив, то лучше сделать метод на вывод массива и вызывать его два раза

// // KISS - keep it simple - сделай это проще (не усложнять код)

// if (arr[0] / 2 * 2 == 0) // вместо (arr[0] % 2 == 0)
// {
//     Console.WriteLine("Чётное");
// }
// // Вывод по KISS: если можно не усложнять, то не надо усложнять.
// // Чаще всего есть уже более понятные и простые решения, нужно их погуглить

// // YAGNI - you ain't gonna need it - тебе это не понадобится (не делать сущностей сверх необходимого)

// void Print(string str)
// {
//     Console.WriteLine(str);
// }
// // Вывод по YAGNI: не создавать лишних методов. если в задаче используется только целочисленный массив,
// // то не стоит заранее писать методы на вывод в консоль массивов с другими типами данных


// // SOLID: S - принцип единственности ответственности
// // Метод, класс или другая сущность должны выполнять только одну функцию

// int[] FillArray(int[] array)
// {
//     // как-то заполняем массив
//     return array;
// }

// void PrintArray(int[] array)
// {
//     // вывод массива
// }
// // Вывод по SOLID, буква S: каждый метод выполняет одну задачу. Не смешивать заполнение массива и его вывод в консоль


// // Правила написания кода (code style)
// // Названия переменных: первое слово с маленькой буквы, остальные с большой, нет подчёркиваний и тире
// int number;
// int numberOfSomething;

// // Названия методов: все слова с большой буквы (осмысленное название)
// void GetNumber(int[] array){}


















// Рекурсия - вызов функции изнутри этой же функции

// функция GetNumber


/// <summary>
/// фывфывфывфывфывфыв
/// </summary>
// int GetNumber()
// {
//     Console.WriteLine("Введите число");
//     string text = Console.ReadLine();

//     if (!int.TryParse(text, out int number))
//     {
//         Console.WriteLine("Введите именно число");
//         // вызываем внутри функции GetNumber функции GetNumber
//         return GetNumber();
//     }

//     return number;
// }

// int number = GetNumber();
// Console.WriteLine($"Получилось число: {number}");


// int[,] SortArr(int[,] ar)
// {
//     int min = ar[0, 0];
//     int minI = 0;
//     int minJ = 0;

//     for (int i = 0; i < ar.GetLength(0); i++)
//     {
//         for (int j = 0; j < ar.GetLength(1); j++)
//         {
//             if (min > ar[i, j])
//             {
//                 min = ar[i, j];
//                 minI = i;
//                 minJ = j;
//             }
//         }
//     }
//     int[,] res = new int[ar.GetLength(0) - 1, ar.GetLength(1) - 1];
//     for (int i = 0; i < ar.GetLength(0); i++)
//     {
//         if (i == minI)
//         {
//             continue;
//         }
//         for (int j = 0; j < ar.GetLength(1); j++)
//         {
//             if (j == minJ)
//             {
//                 continue;
//             }

//             Console.Write(ar[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return ar;
// }


// фишки циклов

// continue -- пропуск итерации и переход к следующей
// for (int i = 0; i < 5; i++)
// {
//     if (i == 3)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
// }

// break -- остановка цикла
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++) 
//     { 
//         if (i == 0 && j == 3)
//         {
//             break;
//         }
//         Console.WriteLine($"{i}, {j}");
//     }
// }