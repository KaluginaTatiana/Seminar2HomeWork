// Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.
Console.WriteLine("Введите последовательно 3 стороны треугольника.");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
if (a + b > c && a + c > b && b + c > a )
{
    if (a == b || a == c || b == c)
    Console.WriteLine("Треугольник со сторонами " + a + "; " + b + "; " + c + " - равнобедренный.");
    else
    Console.WriteLine("Треугольник со сторонами " + a + "; " + b + "; " + c + " - не равнобедренный.");
}
else
{
    Console.WriteLine("Треугольника со сторонами " + a + "; " + b + "; " + c + " - не существует.");
}