// Задача 2. На вход подаются год, номер месяца и день рождения человека, 
// Определить возраст человека на момент 1 июля 2022 года.
Console.WriteLine("Введите год своего рождения.");
int Year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц своего рождения.");
int Mes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день своего рождения.");
int Day = Convert.ToInt32(Console.ReadLine());
HowOldAreYouOnJuly01_2022(Year, Mes, Day);


void HowOldAreYouOnJuly01_2022(int god, int mes, int day)
{
    int YearTest = 2022;
    int MesTest = 7;
    int DayTest = 1;
    if (day > DayTest)
    {
        DayTest = DayTest + 30;
        MesTest = MesTest - 1;
    }
    if (mes > MesTest)
    {
        MesTest = MesTest + 12;
        YearTest = YearTest - 1;
    }
    
    Console.WriteLine("На 01 июля 2022 года Вам исполнилось: ");
    Console.WriteLine((YearTest - god) + " лет, " + (MesTest - mes) + " месяцев, " + (DayTest - day) + " дней.");
}