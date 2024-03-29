﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void SearchPosition(int[,] array, int posRow, int posColumn){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == posRow){
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == posColumn) { Console.WriteLine($"Значение элемента [{posRow},{posColumn}] равно {array[i,j]}");
            return;
            }
        }} else if (i == array.GetLength(0)-1) Console.WriteLine($"Элемента с позицией [{posRow},{posColumn}] в массиве нет");
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите позицию элемента в массиве через пробел (строка столбец): ");
string[] position = Console.ReadLine()!.Split();
int positionRow = int.Parse(position[0]);
int positionColumn = int.Parse(position[1]);

Console.WriteLine();
SearchPosition(array, positionRow, positionColumn);
