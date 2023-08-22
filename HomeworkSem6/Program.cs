// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите количество элементов массива ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];

// for (int i = 0; i < num; i++)
//     {
//         Console.WriteLine($"Введите {i+1} элемент массива ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }

// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i]>0)
//     {
//         count++;
//     }   
// }
// System.Console.WriteLine("Количество чисел больше 0 = " +count);

// Задача 43: Напишите программу, которая найдёт точку
// пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1 ");
double num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k1 ");
double num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2 ");
double num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2 ");
double num4 = Convert.ToInt32(Console.ReadLine());

double x = (num3 - num1) / (num2 - num4);
double y = num2 * x + num1;

System.Console.WriteLine("Ось координат точек пересечения" + x + "," + y);
