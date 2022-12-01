// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine()!);

if(numberA > numberB && numberA > numberC) Console.Write("Число " + numberA + 
    " больше, чем числa " + numberB + " и " + numberC);
if(numberA < numberB && numberC < numberB) Console.Write("Число " + numberB + 
    " больше, чем числa " + numberA + " и " + numberC);
if(numberC > numberA && numberC > numberB) Console.Write("Число " + numberC + 
    " больше, чем числa " + numberA + " и " + numberB);
if(numberA == numberB && numberB == numberC) Console.Write("Введены три одинаковых числа " + numberA);

