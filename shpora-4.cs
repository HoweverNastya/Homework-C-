// Массивы - коллекция однотипных данных
// т.е. несколько значений одного типа данных
// массивы могут быть любого типа данных
// чтобы получить массив надо написать: тип_данных[]

// Определение массива:
// 1. со значением
// int[] array = new int[] { 1, 2, 3 }; // в массиве сразу будут значения [1, 2, 3]
// int[] array = { 1, 2, 3 }; // или так (без new тип_данных[])
// int[] array = { "один", "два", "три" }; // так не получится, нужен правильный тип данных
// string[] stringArray = new string[] { "один", "два", "три" }; // ["один", "два", "три"]

// 2. с указанием размера
// int[] array = new int[3]; // размер 3, заполняется значением по умолчанию: [0, 0, 0]

// Индексы массива: 
// индекс - номер элемента в массиве. индексы начинаются с 0
// int[] array = { 1, 2, 3 };
// int x = array[0]; // первый по счёту элемент массива, индекс 0
// Console.WriteLine(x); // 1
// array[0] = 5; // изменение первого элемента (с индексом 0) с 1 на 5
// Console.WriteLine(array[0]); // 5

// Длина массива:
// длина массива - количество его элементов
// int[] array = { 1, 2, 3 };
// int x = array.Length; // получение количества элементов (длины)
// Console.WriteLine(x); // 3

// Перебор массива:
// int[] array = { 1, 2, 3 };
// // индексы начинаются с 0, поэтому и цикл с 0
// // условие строго меньше длины, потому что последний индекс на 1 меньше длины
// for (int i = 0; i < array.Length; i++) 
// {
//     Console.WriteLine(array[i]); // Выведет 1, потом 2, потом 3
// }

// Строки - массивы букв
// string str = "Hello world";
// Console.WriteLine("Первый символ: " + str[0]); // выводим первый символ строки: буква H
// Console.WriteLine("Все символы строки в стоблик: ");
// for (int i = 0; i < str.Length; i++) 
// {
//     Console.WriteLine(str[i]); // Выведет все символы в столбик
// }
// Отличие строки от массива:
// string str = "Hello world";
// str[0] = 'T'; // ошибка: элементы строки нельзя изменять
// int[] array = { 1, 2, 3 };
// array[0] = 5; // ошибки нет

// Функции (или методы - это одно и то же): 
// Объявление функций:
// тип_данных название_функции(входные_параметры)

// Функция возвращающая результат:
// return - специальное ключевое слово. Оно возвращает результат, который записан после неё
// и останавливает выполнение функции
// int GetSquare(int number)
// {
//     int square = number * number; // получаем квадрат числа
//     return square; // возвращение результата и завершение функции
// }

// int x = GetSquare(5); // вызов функции
// Console.WriteLine(x); // 25
// int y = GetSquare(4);
// Console.WriteLine(y);


// Функция НЕ возвращающая результат:
// void - тип данных специально для функций, которые ничего не возвращают
// void PrintMessage(string message, int number) // void для функции, которая ничего не возвращает
// {
//     Console.WriteLine(message + " " + number);
// }

// PrintMessage("Моё сообщение номер: ", 2); // вызов функции

// Использование return для остановки функции
// void PrintMessage(string message, int number)
// {
//     if (number > 3)
//     {
//         Console.WriteLine("Слишком большой номер");
//         return; // если number > 3, то выводим сообщение и заканчиваем выполнение функции
//         // т.е. дальше выполнение кода не пойдёт
//     }
//     Console.WriteLine(message + " " + number);
// }

// PrintMessage("Моё сообщение номер: ", 4); // вызов функции

// какая-то программа: считывает число с консоли и возвращает его квадрат
// Все функции лучше описывать в начале программы (сверху)
// int GetSquare(int number)
// {
//     return number * number;
// }

// string str = Console.ReadLine();
// int x = int.Parse(str);
// x = GetSquare(x);
// Console.WriteLine(x);


// Распространённая ошибка:
// Лишние действия 2 и 3: 
// 1. Читаем строку (string) с консоли - Console.ReadLine()
// 2. Переводим строку в число - int.Parse
// 3. Переводим число в строку - Convert.ToString
// Ошибка: если нам нужна только строка, то результат Console.ReadLine() не надо переводить в число
// int num = int.Parse(Console.ReadLine());
// string str = Convert.ToString(num); // число в строку
// string str2 = num.ToString(); // число в строку

// Console.WriteLine("num " + num);
// Console.WriteLine("str " + str);
// Console.WriteLine("str2 " + str2);

// Правильное решение:
// string str = Console.ReadLine();

// Получение нескольких значений с консоли
// Split - разбиение строки на части по какому-то символу
Console.WriteLine("Введите числа через пробел: ");
string inputText = Console.ReadLine(); // получаем текст с консоли
string[] stringArray = inputText.Split(' ');

for (int i = 0; i < stringArray.Length; i++)
{
    Console.WriteLine(stringArray[i]);
}

______________________________________

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// Console.WriteLine("Введите число: ");
// string str = Console.ReadLine();
// int sum = 0;

// for (int i = 0; i < str.Length; i++)
// {
//     char currentChar = str[i]; // '1'
//     // для примера пытаемся получить число сразу из символа
//     int positionOfChar = Convert.ToInt32(currentChar); // 49 - порядковый номер '1' в таблице ascii
//     // символ currentChar приводим к строке (меняем тип данных на string)
//     string stringChar = currentChar.ToString(); // "1"
//     int numberFromChar = int.Parse(stringChar); // число 1
//     Console.Write($"Сивол: {currentChar}, позиция: {positionOfChar}, число: {numberFromChar} \n");
// }

// for (int i = 0; i < str.Length; i++)
// {
//     int currentNumber = int.Parse(str[i].ToString());
//     sum += currentNumber; // sum = sum + currentNumber
// }
// Console.WriteLine(sum);




// // Правила по стилю написания кода (code style)
// // Все названия любых структур языка должны описывать то, что они делают или хранят
// // Переменные: первое слово пишется с маленькой буквы, следующие слова с большой
// string textFromConsole; // Текст из консоли
// string text; // вот так не надо, это не информативно

// // Функции (Класс, интерфейсы, структуры, перечисления): Все слова с первого пишутся с большой буквы
// int GetRandomNumber(int from, int to) // Получение случайного числа
// {
//     return 0; // заглушка
// }



// Заполение массива:
// int[] array = {new Random().Next(0, 10)}; // так не сработает, будет только одно число
// int[] array = new int[4]; // 4 - размер (количество)

// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(0, 10); // генерируем случайное число
//     array[i] = randomNumber; // кладём в массив на место с индексом i
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// for (int i = 0; i < array.Length; i++) // изменение массива уже после заполнения
// {
//     array[i] = array[i] + 5;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }