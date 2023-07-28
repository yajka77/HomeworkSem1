// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int num1 = num / 10;
// int num2 = num1 % 10; 

// Console.WriteLine(num2);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int num = new Random().Next(10, 40000);
// Console.WriteLine(num);

// if(num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else if(num > 99 && num < 1000)
// {
//     num = num % 10;
//     Console.WriteLine(num);
// }
// else if(num > 999 && num < 10000)
// {
//     num = num / 10 % 10;
//     Console.WriteLine(num);
// }
// else if(num > 9999 && num <40000)
// {
//     num = num / 100 % 10;
//     Console.WriteLine(num);
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int num = new Random().Next(0, 10);
// Console.WriteLine(num);

// if(num == 1)
// {
//     Console.WriteLine("Понедельник - рабочий день");
// }
// else if(num == 2)
// {
//     Console.WriteLine("Вторник - рабочий день");
// }
// else if(num == 3)
// {
//     Console.WriteLine("Среда - рабочий день");
// }
// else if(num == 4)
// {
//     Console.WriteLine("Четверг - рабочий день");
// }
// else if(num == 5)
// {
//     Console.WriteLine("Пятница - рабочий день");
// }
// else if(num == 6)
// {
//     Console.WriteLine("Суббота - выходной");
// }
// else if(num == 7)
// {
//     Console.WriteLine("Воскресенье - выходной");
// }
// else
// {
//     Console.WriteLine("Такого дня нет");
// }