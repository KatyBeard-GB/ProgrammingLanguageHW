// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number / 100 == 0 || number / 100 > 9 || -number / 100 > 9) Console.WriteLine("Вы ввели не трехзначное число!!!");
else if (number >= 0) Console.WriteLine($"Вторая цифра числа {number} --> {number / 10 % 10}");
else Console.WriteLine($"Вторая цифра числа {number} --> {-number / 10 % 10}");