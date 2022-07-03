// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Работает максимум с 9-значными положительными и отрицательными числами. Как расширить - знаний пока не хватает)
// Не работает на числе больше 2 147 483 647
Console.WriteLine("Введите целое число.");
int num = Convert.ToInt32(Console.ReadLine());
int index = Razryadnost(num);
if (index < 3)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    int third = Math.Abs(num) % (Convert.ToInt32(Math.Pow(10, index - 2)))/(Convert.ToInt32(Math.Pow(10, index - 3)));
    Console.WriteLine("Третья цифра " + third);
}


int Razryadnost(int number)
{
    int count = 1;
    while (number / 10 != 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}

