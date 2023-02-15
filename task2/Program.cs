System.Console.WriteLine("Введите 3х значное число");
int value = Convert.ToInt32(Console.ReadLine());

if ( value > 99)
{
 value = value % 10;
 System.Console.WriteLine($"{value} третья цифра введенного числа");
}
else
{
    System.Console.WriteLine($"{value} не является 3х значным числом");
}