// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

// Console.WriteLine("Первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторую размерность массива");
// int coloms = Convert.ToInt32(Console.ReadLine());

// int[,] matrix= new int[rows,coloms];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i,j]= new Random().Next(0,10);
// Console.Write(matrix[i,j]+ " ");
// }
// Console.WriteLine();
// }
// for(int j =0 ; j < matrix.GetLength(1); j++)
// {
// int changer=matrix.GetLength(0)-1;
// int temp= matrix[0,j];
// matrix[0,j]=matrix[changer,j];
// matrix[changer,j]= temp;
// }
// Console.WriteLine();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write(matrix[i,j]+ " ");
// }
// Console.WriteLine();
// }

//С ПОМОЩЬЮ ФУНКЦИЙ


// Console.WriteLine("Первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторую размерность массива");
// int coloms = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, coloms];

// void CreateArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void ChangeArray()
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int changer = matrix.GetLength(0) - 1;
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[changer, j];
//         matrix[changer, j] = temp;
//     }
// }

// CreateArray();
// PrintArray();
// Console.WriteLine();
// ChangeArray();
// PrintArray();

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("Первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, rows];

// int[,] matrix2 = new int[rows, rows];

// void CreateArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix2[j, i] = matrix[i, j];
//         }
//     }
// }

// CreateArray();
// PrintArray(matrix);
// Console.WriteLine();
// ChangeArray();
// PrintArray(matrix2);

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 0 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:

Console.WriteLine("Первую размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторую размерность массива");
int coloms = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, coloms];

int minEl = int.MaxValue;
int rowsMinEl = 0;
int colomsMinEl = 0;

void CreateArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);

            if (matrix[i, j] < minEl)
            {
                minEl = matrix[i, j];
                rowsMinEl = i;
                colomsMinEl = j;
            }
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != rowsMinEl)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != colomsMinEl)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

    }
}

CreateArray();
PrintArray();
Console.WriteLine();
ChangeArray();