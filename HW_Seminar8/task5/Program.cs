// Задача 62: Заполните спирально массив 4 на 4.

int[,] GetArray(int m, int n, int minElement, int step)
{
    int maxElement = minElement + (m * n - 1) * step;
    int indikcatorHonesty = 0;
    int rows = 2;
    if (m % 2 != 0) { m += 1; n += 1; indikcatorHonesty = 1; rows = 3; }
    int count = m / 2;
    int[,] result = new int[rows, rows];
    if (indikcatorHonesty != 0)
    {
        result[rows / 2, rows / 2] = maxElement;
        maxElement -= step;
        count--;
    };
    (result, maxElement) = SpiralArray(result, maxElement, step);
    count--;
    for (int cou = count; cou > 0; cou--)
    {
        int[,] temp = new int[result.GetLength(0) + 2, result.GetLength(0) + 2];
        for (int i = 1; i < temp.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < temp.GetLength(1) - 1; j++)
            {
                temp[i, j] = result[i - 1, j - 1];
            }
        }
        result = CopyArray(temp);
        (result, maxElement) = SpiralArray(result, maxElement, step);
    }
    return result;
}

(int[,], int) SpiralArray(int[,] array, int maxElement, int step)
{
    int[,] result = CopyArray(array);
    result[1, 0] = maxElement;
    maxElement -= step;
    if (result.GetLength(0) > 2)
    {
        for (int i = 2; i < result.GetLength(0); i++)
        {
            result[i, 0] = maxElement;
            maxElement -= step;
        }
    }
    for (int j = 1; j < result.GetLength(1); j++)
    {
        result[result.GetLength(0) - 1, j] = maxElement;
        maxElement -= step;
    }
    for (int i = result.GetLength(0) - 2; i > -1; i--)
    {
        result[i, result.GetLength(1) - 1] = maxElement;
        maxElement -= step;
    }
    for (int j = result.GetLength(1) - 2; j > -1; j--)
    {
        result[0, j] = maxElement;
        maxElement -= step;
    }
    return (result, maxElement);
}

int[,] CopyArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(0)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = array[i, j];
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

Console.Write("Введите количество строк и столбцов в спиральном массиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите начальный элемент спирального массива: ");
int initialElement = int.Parse(Console.ReadLine()!);

Console.Write("Введите шаг спирального массива: ");
int step = int.Parse(Console.ReadLine()!);

if (rows <= 3) Console.WriteLine("Введите количество строк и столбцов больше 3");
else
{
    int[,] array = GetArray(rows, rows, initialElement, step);
    PrintArray(array);
}