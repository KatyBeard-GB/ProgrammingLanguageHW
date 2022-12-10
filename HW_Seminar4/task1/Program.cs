// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число: ");
double number = double.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
double degree = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{number}^{degree} = {Exponentiation(number,degree)}");

double Exponentiation (double number, double degree){
    double exponentiation = Math.Pow(number, degree);
    return exponentiation;
}