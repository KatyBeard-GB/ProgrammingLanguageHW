// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение N: ");
int numbers = int.Parse(Console.ReadLine()!);

PtintNumbers(numbers);

void PtintNumbers(int number){
    Console.Write($"{number}, ");
    if (number == 1) return;
    else PtintNumbers(number-1);
}
