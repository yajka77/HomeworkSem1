// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[10];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i] + " ");

//     if (array[i] / 2 * 2 < array[i])
//     {
//         count = count + 0;
//     }
//     else
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(", Четных чисел " + count);


// Задача 36: Задайте одномерный массив,
//  заполненный случайными числами. Найдите сумму элементов,
//   стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[6];
// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 11);
//     Console.Write(array[i] + " ");
//     if (i % 2 == 0)
//     {
//         sum = sum + 0;
//     }
//     else
//     {
//         sum = sum + array[i];
//     }
// }
// System.Console.WriteLine("Сумма " +sum);



// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[5.45, 7.62, 2.46, 3.23, 8.87];

double max = array[i];
double min = array[i];
for (int i = 0; i < array.Length; i++)
{
    if (i > i + 1)
    {
        i = max;
    }
    else if (i < i + 1)
    {
        i = min;
    }
}
double result = max[i] - min[i];
System.Console.WriteLine(result);