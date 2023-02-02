//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
int DayWeek (int arg1)
{
    int day;
    if (num <= 5)
    {
        Console.WriteLine("нет");
    }
    if (num > 5)
    {
        Console.WriteLine("да");
    }
    if (num > 7)
    {
        Console.WriteLine("необходимо ввести число от 1 до 7");
    }
    day = num;
    return day;
}

int number = DayWeek(num);