// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
    }
    return res;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

double[] array = GetArray(5);
PrintArray(array);
Console.Write(" -> ");

double MinusMaxMin(double[] array){
    double minus = 0;
    int indexMin = 0;
    int indexMax = 0;
    for (int i = 1; i<array.Length; i++){
        if (array[i] < array[indexMin]) indexMin = i;
        if (array[i] > array[indexMax]) indexMax = i;
    }
    minus = array[indexMax] - array[indexMin];
    return minus;
}

Console.Write($"Разница между максимальным и минимальным элементами равна {MinusMaxMin(array)}");