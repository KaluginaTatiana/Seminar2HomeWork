// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели, исходя из порядка, что понедельник - 1-й день недели ... воскресенье - 7-й день недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7 || day < 1)
{
    Console.WriteLine("Ошибка. Введите число от 1 до 7.");
}
else
{
    int[] array = { 1, 2, 3, 4, 5, 6, 7 };
    string[] week = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
    int index = 0;
    int count = 0;
    while (index < 7)
    {
        if (day == array[index])
        {
            count = index;
        }
        index++;
    }
    if (count == 5 | count == 6)
    {
        Console.WriteLine("Выходной - " + week[count] + ".");
    }
    else
    {
        Console.WriteLine("Рабочий день - " + week[count] + ".");
    }
}