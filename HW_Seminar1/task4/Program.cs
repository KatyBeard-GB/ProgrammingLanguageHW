// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите положительное число: ");
int number = int.Parse(Console.ReadLine()!);

int count = 2;

if(number == 1) {
    Console.Write("Четных чисел между 1 и 1 нет.");
} else if(number < 1) {
    Console.Write("Число введено неверно. Попробуйте ещё раз.");
} else {
    Console.Write("Все четные числа от 1 до " + number + ": ");
    while(count < number-1) {
        Console.Write(count + ", ");
        count += 2;
    }
    Console.Write(count);
}
