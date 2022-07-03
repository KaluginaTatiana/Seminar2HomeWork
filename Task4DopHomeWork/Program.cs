// Задача 4. Дано натуральное число, в котором все цифры различны. 
// Определить, какая цифра расположена в нем левее: максимальная или минимальная.
// Не работает на числе больше 2 147 483 647
Console.WriteLine("Введите натуральное число, в котором все цифры различные.");
int nat = Convert.ToInt32(Console.ReadLine());
int razr = Razryadnost(nat);

int[] array = new int[razr];
int index = razr - 1;
while (index >= 0)
{
    array[index] = nat % 10;
    nat = nat / 10;
    index = index - 1;
}

int IndexMaxNum = FindMax(array);
int IndexMinNum = FindMin(array);
if (IndexMaxNum < IndexMinNum)
Console.WriteLine("Левее расположена максимальная цифра числа.");
else
Console.WriteLine("Левее расположена минимальная цифра числа.");


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

int FindMax(int[] Array)
{
    int count = 0;
    int length = Array.Length;
    int max = Array[count];
    int MaxCount = 0;
    while (count < length)
    {
        if (Array[count] > max)
        {
            max = Array[count];
            MaxCount = count;
        }
        count++;
    }
    return MaxCount;
}

int FindMin(int[] Array)
{
    int count = 0;
    int length = Array.Length;
    int min = Array[count];
    int MinCount = 0;
    while (count < length)
    {
        if (Array[count] < min)
        {
            min = Array[count];
            MinCount = count;
        }
        count++;
    }
    return MinCount;
}