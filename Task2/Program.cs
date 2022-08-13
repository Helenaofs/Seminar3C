// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using System;

Console.WriteLine("Введите координаты двух точек.");
Console.WriteLine("Координаты точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double distance(double x1, double y1, double z1,
                double x2, double y2, double z2)
{
   return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

double length = Math.Round(distance(x1, y1, z1, x2, y2, z2), 2);

Console.WriteLine("Расстояние между точками в 3D пространстве - " + length);
