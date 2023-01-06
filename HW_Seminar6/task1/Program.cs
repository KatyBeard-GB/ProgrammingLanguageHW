// Задача 41: Пользователь вводит с клавиатуры M
// чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

Console.Write("Сколько чисел вы хотите ввести? ");
int M = int.Parse(Console.ReadLine()!);
int[] array = GetArray(M);
int positiveNumber = PositiveNumbers(array);

Console.Write($"Вы ввели {positiveNumber} чисел(-ла) больше 0");

int[] GetArray(int size){
    int[] res = new int[size];
    for(int i=0;i<size;i++){
        Console.Write($"Введите {i+1} число: ");
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}

int PositiveNumbers(int[] array){
    int res = 0;
    for(int i = 0; i<array.Length; i++){
        if (array[i]>0) res++;
    }
    return res;
}
