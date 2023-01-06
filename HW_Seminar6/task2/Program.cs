// Задача 43 Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double[] arrayBK = GetBK(2);
Console.WriteLine(string.Join(" ",arrayBK));
double[] arrayPoint = IntersectionPoint(arrayBK);
Console.WriteLine($"Точкой пересечния двух прямых y = {arrayBK[0]} * x + {arrayBK[1]}, y = {arrayBK[2]} * x + {arrayBK[3]} является точка [{arrayPoint[0]};{arrayPoint[1]}]");

double[] GetBK(int numberLines){
    double[] res = new double[numberLines*2];
    for(int i=0;i<numberLines*2;i+=2){
        Console.Write($"Введите число k {i+1} уравнения: ");
        res[i] = double.Parse(Console.ReadLine()!);
        Console.Write($"Введите число b {i+1} уравнения: ");
        res[i+1] = double.Parse(Console.ReadLine()!);
    }
    return res;
}

double[] IntersectionPoint(double[] array){
    double[] res = new double[array.Length/2];
    res[0] = (array[3] - array[1])/(array[0]-array[2]);
    res[1] = array[0]*res[0]+array[1];
    return res;
}
