// Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);


Console.Clear();
Console.Write("Точка А Координата X: ");
int X1 = int.Parse(Console.ReadLine());

Console.Write("Точка А Координата Y: ");
int Y1 = int.Parse(Console.ReadLine());

Console.Write("Точка B Координата X: ");
int X2 = int.Parse(Console.ReadLine());

Console.Write("Точка B Координата Y: ");
int Y2 = int.Parse(Console.ReadLine());

double s = Math.Sqrt((X1-X2)^2 + (Y1-Y2)^2);
Console.Write($"Расстояние между точками {s} ");
Console.WriteLine($"{s}");