// Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.WriteLine("Введите координаты первой точки");
System.Console.WriteLine("Введите переменную х");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите переменную y");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите переменную z");
double z1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки");
System.Console.WriteLine("Введите переменную х");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите переменную y");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите переменную z");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));