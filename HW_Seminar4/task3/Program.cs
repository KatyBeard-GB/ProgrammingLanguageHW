// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);
int[] array = new int[count];
SetArray(array);
Console.Write("Вы ввели слеующий массив: ");
PrintArray(array);

void SetArray (int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray (int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}