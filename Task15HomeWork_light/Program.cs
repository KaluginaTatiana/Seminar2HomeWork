﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели, исходя из порядка, что понедельник - 1-й день недели ... воскресенье - 7-й день недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day <=7 && day >= 1)
{
    if (day == 6 | day == 7)
    Console.WriteLine("да");
    else
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Ошибка. Число должно быть от 1 до 7.");
}
