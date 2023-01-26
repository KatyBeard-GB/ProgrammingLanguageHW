// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SearchMinIndexRows(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[0, i];
    }
    int minSum = sum;
    int indexMinRows = 0;
    sum = 0;
    if (array.GetLength(0) > 1)
    {
        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if (minSum > sum)
            {
                minSum = sum;
                indexMinRows = i;
            }
            sum = 0;
        }
    }
    else AnswerSearchMinIndexRows(array, indexMinRows, minSum);
    AnswerSearchMinIndexRows(array, indexMinRows, minSum);
}

void AnswerSearchMinIndexRows(int[,] array, int indexMin, int sumMin)
{
    Console.Write($"Строка {indexMin+1} (");
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
        Console.Write($"{array[indexMin, j]}, ");
    }
    Console.Write($"{array[indexMin, array.GetLength(1)-1]}) имеет наименьшую сумму элементов: {sumMin}.");
}

Console.Write("Введите количество строк и столбцов в прямоугольном массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] array = GetArray(rows, rows, -10, 10);
PrintArray(array);
Console.WriteLine();

SearchMinIndexRows(array);
