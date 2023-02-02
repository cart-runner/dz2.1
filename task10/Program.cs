//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number / 10;
int num2 = num1 % 10;
Console.WriteLine($"вторая цифра числа {number} равна {num2}");