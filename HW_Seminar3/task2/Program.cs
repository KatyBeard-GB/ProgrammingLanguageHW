// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X первой точки: ");
double ax = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y первой точки: ");
double ay = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z первой точки: ");
double az = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату X второй точки: ");
double bx = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y второй точки: ");
double by = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z второй точки: ");
double bz = double.Parse(Console.ReadLine()!);

double dist = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)+Math.Pow(bz - az, 2));

Console.Write($"Расстояние между точками А({ax};{ay};{az}) и В({bx};{by};{bz}) --> {Math.Round(dist, 2)}");

