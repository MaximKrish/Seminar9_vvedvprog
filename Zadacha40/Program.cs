﻿string f(int a, int b, int c)
{
    if ((a + b) > c && (b + c) > a && (c + a) > b)
        return "Может существовать треугольник ";
    return "Не может существовать треугольник ";
}
int a, b, c;
Console.WriteLine("Задайте сторону a ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте сторону b ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте сторону c ");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a, b, c));
