// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Boolean begin = true;
// while (begin)
// {
// Console.WriteLine("Введите первое число: ");

// int num_A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");

// int num_B = Convert.ToInt32(Console.ReadLine());

// if (num_A > num_B)
//     {
//     Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
//     }
// else
//     {
//     Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
//     }
// break;
// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Boolean begin = true;
// while (begin)
// {
// Console.WriteLine("Введите 3 числа:");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// int num_2 = Convert.ToInt32(Console.ReadLine());
// int num_3 = Convert.ToInt32(Console.ReadLine());
// int max = num_1;
// if (num_2 > max)
// {
//     max = num_2;
// }
// if (num_3 > max)
// {
//     max = num_3;
// }
// Console.WriteLine("Наибольшее из введённых чисел -> " + max);
// break;
// }


// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// int num;
// Boolean begin = true;
// while (begin)
// {
// Console.WriteLine("Введите число:");
// num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 1)
//     {
//         Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
//     }
// else
//     {
//         Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
//     }
// break;
// }


// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// int num;
// Boolean begin = true;
// while (begin)
// {
// int i = 1;
// bool not = true;

// Console.WriteLine("Введите число:");
// num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Чётные числа от 1 до " + num);
// while (i <= num)
// {
// if (i % 2 != 1)
// {
// Console.Write(i + ", ");
// not = false;
// }
// i++;
// }

// if (not)
// {
// Console.WriteLine("Нет чётных чисел!");
// }
// break;
// }

// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int InCenter(int a)
// {
//     int result = ((a / 10) % 10);
//     return result;
// }
// int number = ReadInt("Введите трехзначное число: ");
// int amount = number.ToString().Length;

// if (amount < 3 || amount > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(InCenter(number));
// }

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }
// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// string WorkHoliday(int a)
// {
//     if (a > 0 && a < 8)
//     {
//         if (a == 7 || a == 6)
//         {
//             Console.Write("Под цифрой " + a + " - Выходной");
//         }
//         else
//         {
//             Console.Write("Под цифрой " + a + " - Рабочий");
//         }
//     }
//     else
//     {
//         Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
//     }
//     return " день.";
// }
// int dayNumber = ReadInt("Введите число от 1 до 7: ");
// Console.WriteLine(WorkHoliday(dayNumber));

// // Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// using System;
// class HelloWorld {
//   static bool isPal(int n)
//   {
//       int r=0,nn=n;
//       while (n>0)
//       {
//           r=r*10+n%10;
//           n=n/10;
//       }
//       return r==nn;
//   }
//   static void Main() {
//     int n;  
//     Console.Write("Введите число: ");
//     n=Convert.ToInt32(Console.ReadLine());
//     if (isPal(n))
//        Console.WriteLine("Палиндром");
//     else   
//        Console.WriteLine("Не палиндром");
//   }
// }

// // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");

// // Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int number = ReadInt("Введите число N: ");

// for (int i = 1; i <= number; i++)
// { 
//     Console.Write($"{i*i*i} ");
// }

// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵);   2, 4 -> 16   */

// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(a + " в степени " + b + " = " + result);
// }
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int numberA = ReadInt("Введите число: ");
// int numberB = ReadInt("Введите степень: ");
// ToDegree(numberA, numberB); 

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11;  82 -> 10;  9012 -> 12   */

// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine($"Cумма цифр {sum}");
// }
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int number = ReadInt("Введите число: ");

// int len = NumberLen(number);
// SumNumbers(number, len);

// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// string RemovingSpaces (string series){
//   string seriesNew = "";
//   for (int i = 0; i < series.Length; i++)
//   {
//     if (series[i] != ' ') 
//     {
//       seriesNew += series[i];
//     }
//   }
//   return seriesNew;
// }
// void СheckNumber2 (int  series){

//       if (series == '0'||series == '1'||series == '2'
//       ||series == '3'||series == '4'||series == '5'||series == '6'
//       ||series == '7'||series == '8'||series == '9'||series == ','
//       ||series == '-')
//       {
//       }
//         else {
//           Console.WriteLine($"Ошибка ввода символа. Вводи цифры.");
//       }
// }
// int[] ArrayOfNumbers(string seriesNew){ 

//   int[] arrayOfNumbers = new int[1];   

//   int j =0;

//   for (int i = 0; i < seriesNew.Length; i++){
//     string seriesNew1 = "";

//     while (seriesNew[i] != ',' && i < seriesNew.Length){
//       seriesNew1 += seriesNew[i];
//       СheckNumber2(seriesNew[i]);
//       i++;
//     }
//     arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);   
//     if (i < seriesNew.Length-1){
//       arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    
//     }
//     j++;
//   }
//   return arrayOfNumbers;
// }
// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   Console.Write("[");
//   while(index < count){
//     Console.Write(coll[index]);
//     index++;
//     if (index < count){
//       Console.Write(", ");
//     }
//   }
//   Console.Write("]");
// } 
// Console.Write("Введите ряд чисел, разделенных запятой : ");
// string? seriesOfNumbers = Console.ReadLine();

// seriesOfNumbers = seriesOfNumbers + ",";    

// string seriesNew = RemovingSpaces(seriesOfNumbers);

// int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

// PrintArry(arrayOfNumbers);

// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите количество массивов, заполненный случайным положительным трехзначным числом");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int count = 0;
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     count++;
// }

// Console.WriteLine($"Количество чётных чисел в массиве -> {count} ");

// void FillArrayRandomNumbers(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int size = 4;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int sumNumbersEvenIndex = 0;

// for (int i = 1; i < numbers.Length; i += 2)
// {
//     sumNumbersEvenIndex += numbers[i];
// }
// Console.Write(sumNumbersEvenIndex);

// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// // [3 7 22 2 78] -> 76

// int size = 10;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int max = numbers[0];
// int min = numbers[0];

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
//     else if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }
// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Минимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 555);
//     }
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// // Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// // 0, 7, 8, -2, -2 -> 2 -1, 
// //-7, 567, 89, 223-> 3

// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine());
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");


// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }

// // Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 y = k2 * x + b2 значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

// //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк  ");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] numbers = new int[6, 8];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Random random = new Random();
// int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("---------------------------");
// Console.WriteLine(arr.GetLength(0));
// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($"{ sum / arr.GetLength(0)} ");
// }
// Console.ReadLine();

// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// Console.WriteLine("введите количество строк");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine();
// Console.WriteLine("Массив до изменения");
// PrintArray(numbers);

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1) - 1; j++)
//     {
//         for (int z = 0; z < numbers.GetLength(1) - 1; z++)
//         {
//             if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
//             {
//                 int temp = 0;
//                 temp = numbers[i, z];
//                 numbers[i, z] = numbers[i, z + 1];
//                 numbers[i, z + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Массив с упорядоченными значениями");
// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите размер квадратного массива");
// int massVol = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[massVol, massVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int minsum = Int32.MaxValue;
// int indexLine = 0;

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         sum = sum + numbers[i, j];        
//     }
//     if (sum < minsum)
//     {
//         minsum = sum;
//         indexLine++;
//     }
// }

// Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (indexLine) + ", с суммой элементов равной: " + (minsum));

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// int size = InputInt("размерность матриц: ");
// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];
// FillArrayRandomNumbers(matrixA);
// FillArrayRandomNumbers(matrixB);
// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//         }
//     }
// }
// Console.WriteLine("Матрица - А");
// PrintArray(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица - В");
// PrintArray(matrixB);
// Console.WriteLine();
// Console.WriteLine("Произведение матриц А*В");
// PrintArray(matrixC);

// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)

// int deep1 = InputInt("Введите размерность 1: ");
// int deep2 = InputInt("Введите размерность 2: ");
// int deep3 = InputInt("Введите размерность 3: ");
// int countNums = 89;

// if (deep1 * deep2 * deep3 > countNums)
// {
//     Console.Write("Массив слишком большой");
//     return;
// }

// int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

// for (int i = 0; i < resultNums.GetLength(0); i++)
// {
//     for (int j = 0; j < resultNums.GetLength(1); j++)
//     {
//         for (int k = 0; k < resultNums.GetLength(2); k++)
//         {
//             Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,,] Create3DMassive(int size1, int size2, int size3)
// {
//     int[,,] array = new int[size1, size2, size3];
//     int[] values = new int[countNums];
//     int num
//      = 10;
//     for (int i = 0; i < values.Length; i++)
//         values[i] = num
//         ++;

//     for (int i = 0; i < values.Length; i++)
//     {
//         int randomInd = new Random().Next(0, values.Length);
//         int temp = values[i];
//         values[i] = values[randomInd];
//         values[randomInd] = temp;
//     }

//     int valueIndex = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = values[valueIndex++];
//             }
//         }
//     }
//     return array;
// }


// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// // Задача 62 (дополнительная). Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray(nums);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// NaturalToLow(number, count);


// void NaturalToLow(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         NaturalToLow(n, count + 1);
//         Console.Write(count + " ");
//     }
// }

// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);
