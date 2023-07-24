// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Введите число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number2 = Convert.ToInt32(Console.ReadLine());


// if(number2 > number1)
// {
//     Console.WriteLine(number2 + " больше " + number1);
// }
// else
// {
//     Console.WriteLine(number1 + " больше " + number2);
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = number1;

// int count = 0;

// while(count < 3)
// {
//     if(number2 > max)
//     {
//     max = number2;
//     }
//     else if(number3 > max)
//     {
//     max = number3;
//     }
//     count ++;
// }
// Console.WriteLine(max);

// или

// Console.Write("Введите первое число: ");
// int OneNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int TwoNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int ThreeNumber = Convert.ToInt32(Console.ReadLine());

// int max=OneNumber;

// if(OneNumber < TwoNumber)
// {
//     max=TwoNumber;
// }
// else if(max < ThreeNumber)
// {
//    max=ThreeNumber;
// }
// Console.Write(max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//     Console.WriteLine("Число чётное");
// }
// else
// {
//     Console.WriteLine("Число нечётное");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;


while(count <= number)
{
    if(count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count ++;
}
