// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// string PrintNumbers(int num)
// {
//     if (num == 1)
//     {
//         return num.ToString();
//     }
//     if (num > 0)
//     {
//         return num + "; " + PrintNumbers(num - 1);
//     }
//     else
//     {
//         return num + "; " + PrintNumbers(num + 1);
//     }
// }
// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine("N = " + num + " -> \"" + PrintNumbers(num) + "\"");

// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке
//   от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите значение числа M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите значение числа N: ");
// int n = int.Parse(Console.ReadLine());

// int SumNums(int num1, int num2)
// {
//     if(num1 == num2)
//     {
//         return num1;
//     }
//     if(num1 < num2)
//     {
//         return num2 + SumNums(num1, num2 -1);
//     }
//     else
//     {
//         return num2 + SumNums(num1, num2 +1);
//     }
// }
// Console.Write(SumNums(m, n));
