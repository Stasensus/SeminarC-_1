System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    System.Console.WriteLine("Первое число больше второго");
}
else System.Console.WriteLine("Второе число больше первого");