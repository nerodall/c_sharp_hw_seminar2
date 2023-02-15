System.Console.WriteLine("Введите число дня недели от 1 до 7");
int value = Convert.ToInt32(Console.ReadLine());



if (value > 5 && value < 8)
{
    System.Console.WriteLine("этот день недели выходной");
}
else
{

    System.Console.WriteLine("этот день недели не является выходным");
}

