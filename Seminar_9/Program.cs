// Задача 63: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа
//   в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int startNum=1;

// Console.WriteLine(PrintNumbers(startNum,num));

// string PrintNumbers(int start, int end)
// {
// if(start==end)
// {
// return start.ToString();
// }
// return (start+ " "+ PrintNumbers(start+1,end));
// }

// Задача 65: Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа
//   в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.WriteLine("Введите начальное число");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите конечное число");
// int num2 = int.Parse(Console.ReadLine());

// if (num1 < num2)
// {
//     Console.WriteLine(PrintNumbers(num1, num2));
// }
// else
// {
//     Console.WriteLine("Ввод некорректный");
// }

// string PrintNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// Задача 67: Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());


// Console.WriteLine(PrintNumbers(num));

// int PrintNumbers(int num)
// {
//     if (num <= 0)
//     {
//         return 0;
//     }
//     return (num % 10 + PrintNumbers(num / 10));
// }

// Задача 69: Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А в целую степень B
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());


Console.WriteLine("Введите число B: ");
int num2 = int.Parse(Console.ReadLine());



System.Console.WriteLine(PrintNumbers(num1, num2));

double PrintNumbers(int num1, int num2)
{
    if (num2 == 1)
    {
        return num1;
    }
    if (num2 == 0)
    {
        return 1;
    }


    if (num2 < 0)
    {
        double n = 1 / (Math.Pow(num1, num2));
        return n;
    }
    return (num1 * PrintNumbers(num1, num2 - 1));
}