﻿System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 2;
if (number > 2)
{
    // number1 = 2;
    while (number1 <= number)
    {
        System.Console.WriteLine(number1);
        number1 = number1 + 2;
    }
}
if (number < 2)
{
    System.Console.WriteLine("Некорректная цифра. Чётных нет");
}
if (number == 2)
{
    System.Console.WriteLine(number);
}