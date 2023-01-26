// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int numberM = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int numberN = int.Parse(Console.ReadLine()!);

int sum = 0;
sum = SumNumbers(numberM,numberN,sum);
Console.WriteLine($"Сумма натуральных элементов от {numberM} до {numberN} равна {sum}.");

int SumNumbers(int number, int maxNumber, int result){
    if (number == maxNumber+1) return result;
    else return SumNumbers(number+1,maxNumber,result+number);
}