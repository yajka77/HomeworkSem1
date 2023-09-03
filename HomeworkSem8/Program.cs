// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] matrix = new int[10,3]; 
 
// void NewMass(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             array[i,j] = new Random().Next(0,10); 
//         } 
//     } 
// } 
 
// void StMass(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             if (j == 0) 
//             { 
//                 System.Console.Write("["); 
//             } 
//             System.Console.Write(array[i,j]); 
//             if (j == array.GetLength(1) - 1) 
//             { 
//                 System.Console.Write("]"); 
//             } 
//             else 
//             { 
//                 System.Console.Write("; "); 
//             } 
//         } 
//         System.Console.WriteLine(); 
//     } 
// } 
// void SortArray(int[,] array) 
// { 
//   for (int i = 0; i < array.GetLength(0); i++) 
//   { 
//     for (int j = 0; j < array.GetLength(1); j++) 
//     { 
//       for (int k = 0; k < array.GetLength(1)-1;k++) 
//       { 
//         if (array[i, k] < array[i, k + 1]) 
//         {                                
//           int temp = array[i, k + 1];   
//           array[i, k + 1] = array[i, k]; 
//           array[i, k] = temp; 
//         } 
//       } 
//     } 
//   } 
// } 
// NewMass(matrix); 
// StMass(matrix); 
// SortArray(matrix); 

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка


// int[,] matrix = new int[3,5]; 
 
// void Mass(int[,]array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             array[i,j] = new Random(). Next(0,10); 
//         } 
//     } 
// } 
// void Mass1(int[,]array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             System.Console.Write(array[i,j]+ " "); 
//         } 
//         System.Console.WriteLine(); 
//     } 
// } 
// void Mass2(int[,]array) 
// { 
//     int minline = 0; 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         int sum = 0; 
//          int min = int.MaxValue; 
//         for (int j = 0; j < array.GetLength(1); j++) 
//             { 
//                 sum+= array[i,j]; 
//             } 
//                 System.Console.WriteLine($"Сумма строки {i + 1} = {sum}"); 
//                 if (sum<min) 
//                 { 
//                     minline = i; 
 
//                 } 
 
//     } 
//     System.Console.WriteLine($"Строка с наименьшей суммой {minline}"); 
// } 
 
// Mass(matrix);
// Mass1(matrix);
// Mass2(matrix);

