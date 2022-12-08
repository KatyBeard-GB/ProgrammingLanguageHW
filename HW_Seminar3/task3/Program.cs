// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 1) {
    int result = number;
    Console.Write($"Таблица кубов чисел от {number} до 1: ");
    while (result < 1)
    {
        Console.Write($"{result * result*result}, ");
        result++;
    }
    Console.Write($"{result * result*result}");
}
else
{
    int result = 1;
    Console.Write($"Таблица кубов чисел от 1 до {number}: ");
    while (result < number)
    {
        Console.Write($"{result * result*result}, ");
        result++;
    }
    Console.Write($"{result * result*result}");
}
