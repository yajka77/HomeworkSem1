// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество элементов массива ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i]>0)
    {
        count++;
    }   
}
System.Console.WriteLine("Количество чисел больше 0 = " +count);