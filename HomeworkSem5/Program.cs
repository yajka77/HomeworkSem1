﻿// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");

    if (array[i] / 2 * 2 < array[i])
    {
        count = count + 0;
    }
    else
    {
        count++;
    }
}
System.Console.WriteLine(", Четных чисел " + count);