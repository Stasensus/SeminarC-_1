System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (num2 > num1)
{
    max = num2;
}
else max = num1;
if (num3 > max)
{
    System.Console.WriteLine("Максимальное число " + num3);
}
else System.Console.WriteLine("Максимальное число " + max);