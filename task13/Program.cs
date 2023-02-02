//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int Digit(int arg1)
{
    int result = 0;
    if (number >= 100)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;

    
}    
 
int num = Digit(number);
Console.WriteLine(num);