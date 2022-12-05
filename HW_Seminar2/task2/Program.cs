// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number / 100 == 0) Console.WriteLine($"В введенном числе {number} нет третьей цифры");
else
{
    int numberThree = number;
    while (numberThree > 1000 || -numberThree > 1000) numberThree /= 10;
    if (numberThree >= 0) Console.WriteLine($"Третья цифра числа {number} --> {numberThree % 10}");
    else Console.WriteLine($"Третья цифра числа {number} --> {-numberThree % 10}");
}
