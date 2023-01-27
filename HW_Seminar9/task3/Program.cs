// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите 1 неотрицательное число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2 неотрицательное число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 < 0 || number2 < 0) Console.WriteLine("Ошибка!!! Вы ввели отрицательные числа.");
else {
    int result = AkkermanFunction(number1,number2);
    Console.WriteLine($"A({number1},{number2}) = {result}");
}

int AkkermanFunction(int m, int n){
    if (m == 0) return n+1;
    else if (m>0 && n==0) return AkkermanFunction(m-1,1);
    else if (m>0 && n>0) return AkkermanFunction(m-1,AkkermanFunction(m,n-1));
    else return 0;
}
