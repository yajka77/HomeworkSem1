// Задача 46: Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// System.Console.WriteLine("Первая размерность массива");
// int rows =Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Вторая размерность массива");
// int colomns =Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows, colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0, 10);
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// System.Console.WriteLine("Первая размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Вторая размерность массива");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = i + j;
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы
// на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4

// System.Console.WriteLine("Первая размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Вторая размерность массива");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// System.Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             matrix[i,j] = matrix[i,j] * matrix[i,j];
//         }
//         Console.Write(matrix[i, j] + " ");
//     }
//     System.Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

System.Console.WriteLine("Первая размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Вторая размерность массива");
int colomns = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int[,] matrix = new int[rows, colomns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");

        if(i == j)
        {
            // sum = sum+matrix[i,j];
            sum+=matrix[i,j];
        }
    }
    Console.WriteLine();
}
System.Console.WriteLine("Сумма равняется "+ sum);