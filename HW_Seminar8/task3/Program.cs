// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] ProductMatrices(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

Console.Write("Введите количество строк в 1 матрице: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов в 1 матрице: ");
int columns1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк во 2 матрице: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов во 2 матрице: ");
int columns2 = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] array1 = GetArray(rows1, columns1, -10, 10);
Console.WriteLine("Первая матрица: ");
PrintArray(array1);

Console.WriteLine();
int[,] array2 = GetArray(rows2, columns2, -10, 10);
Console.WriteLine("Вторая матрица: ");
PrintArray(array2);
Console.WriteLine();

if (columns1 != rows2) Console.WriteLine("Ошибка!!! Для нахождения произведения введите одинаковое количество столбцов в 1 матрице и строк во 2.");
else
{
    int[,] resultArray = ProductMatrices(array1, array2);
    Console.WriteLine("Результирующая матрица: ");
    PrintArray(resultArray);
}